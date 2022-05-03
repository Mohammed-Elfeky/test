using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Linq;
namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        THECONTEXT db;
        public ProductController(THECONTEXT db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {

            var products = db.Products.ToList();
            return View(products);
        }
    }
}
