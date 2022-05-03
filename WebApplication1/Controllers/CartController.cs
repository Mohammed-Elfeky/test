using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using WebApplication1.Models;
using WebApplication1.ViewModel;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class CartController : Controller
    {
        THECONTEXT db;
        public CartController(THECONTEXT db)
        {
            this.db = db;
        }

        [Authorize]
        public IActionResult Add(int id)
        {
            //get the loggedin user id
            string userId = User.
                        Claims.
                        FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)
                        .Value;

            var userHasUnSuubmittedOrdr =db.
                                         Orders.
                                         Where(o => o.User_id == userId && o.submitted == "false").
                                         SingleOrDefault()
                                         ;
            
            # region check if there is UnSubmitted order for this user
            if (userHasUnSuubmittedOrdr!=null)
            {
                #region check if the product  exists in the order
                var productExist = db.OrdersProducts.Any(
                    op => op.o_id == userHasUnSuubmittedOrdr.Id && op.p_id==id
                );
                if (productExist == true)
                {   
                    //increase the quantity of the product
                    OrderProduct op=db.OrdersProducts.FirstOrDefault(op=>op.p_id==id && op.o_id==userHasUnSuubmittedOrdr.Id);
                    op.quantity += 1;
                    db.SaveChanges();
                    //go to 
                    return RedirectToAction("getInstructors", "Instructor");
                }
                #endregion


                #region if the product doesnt exist in the order
                //if the product doesnt exists in the order
                //create new orderproduct row
                //assign the product id to it and make the quantity 1
                OrderProduct opRow =new OrderProduct()
                {
                    o_id=userHasUnSuubmittedOrdr.Id,
                    p_id=id,
                    quantity=1
                };
                db.OrdersProducts.Add(opRow);
                db.SaveChanges();
                return RedirectToAction("getInstructors", "Instructor");
                #endregion
            }
            #endregion

            #region if there is no unsubmitted order assigned to that user
            //create unsubmitted order 
            //and assign user id to the order
            Order newOrder =new Order() { User_id=userId,submitted="false"};
            db.Orders.Add(newOrder);
            db.SaveChanges();
            int createdOrderId=newOrder.Id;

            //assign the created order to the product in the orderProduct Table
            OrderProduct ob = new OrderProduct()
            {
                o_id = createdOrderId,
                p_id = id,
                quantity = 1
            };
            db.OrdersProducts.Add(ob);
            db.SaveChanges ();
            return RedirectToAction("getInstructors", "Instructor");
            #endregion

        }

        [Authorize]
        public IActionResult Show()
        {
            //get the loggedin user id
            string userId = User.
                        Claims.
                        FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)
                        .Value;

            //check if there is UnSubmitted order for this user
            Order theUnSubmittedOrder = db.Orders.
                            Where(o => o.User_id == userId && o.submitted == "false")
                            .SingleOrDefault()
                                          ;
            //if there is display it
            if (theUnSubmittedOrder != null)
            {
                                  var order = db.OrdersProducts.
                                              Include(op=>op.product).
                                              Where(op => op.o_id == theUnSubmittedOrder.Id).
                                              Select( op=> new cartItenVM() { ordr_id=op.o_id, name=op.product.Name,quantity=op.quantity}).
                                              ToList();
                                              ViewData["o_id"] = order[0].ordr_id;
                return View(order);
            }
            return View();
        }

        List<CoockieCartItem> getCartFromCoockie()
        {
            #region get cart list from cookie as string
            string cartListAsString =  User.
            Claims.
            FirstOrDefault(c => c.Type == "CART")
            .Value;
            #endregion

            #region convert string cart to list and return it
            return JsonConvert.DeserializeObject<List<CoockieCartItem>>(cartListAsString);
            #endregion
        }

        void returnCartToCoockie(List<CoockieCartItem> cart)
        {

        //stringfy list ==>> string
        string listAsString = JsonConvert.
            SerializeObject(cart, Formatting.Indented);


            //foreach(var item in User.Claims)
            //{
            //    if(item.Type == "CART")
            //    {
            //        item.Value = listAsString;
            //    }
            //    else
            //    {

            //    }
            //}


            string cartListAsString = User.
            Claims.
            FirstOrDefault(c => c.Type == "CART")
            .Value;




        }


        
        public IActionResult Submit(int id)
        {
            #region change the submitted col of the order to true
            Order o=db.Orders.Find(id);
            o.submitted = "true";
            db.SaveChanges();
            #endregion

            return View("Show");
        }

    }
}
