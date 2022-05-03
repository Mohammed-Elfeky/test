using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModel;
using WebApplication1.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Claims;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AccountController(
            UserManager<AppUser> _userManager
            , SignInManager<AppUser> _signInManager
            )
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        [HttpGet]
        public  IActionResult signUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> signUp(signUPvm signUPvm)
        {
            if (ModelState.IsValid == true)
            {
                AppUser userModel = new AppUser();
                userModel.UserName = signUPvm.UserName;
                userModel.Address = signUPvm.Address;
                userModel.PasswordHash = signUPvm.Password;
                IdentityResult result = await userManager.CreateAsync(userModel, signUPvm.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(userModel, false);
                    return RedirectToAction("getInstructors", "Instructor");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(signUPvm);
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(signINvm userVM)
    {
        if (ModelState.IsValid == true)
        {
            AppUser userModel = await userManager.FindByNameAsync(userVM.UserNAme);
            if (userModel != null)
            {
                bool found = await userManager.CheckPasswordAsync(userModel, userVM.Password);
                if (found == true)
                {
                        //await signInManager.SignInAsync(userModel, true);
                        List<Claim> extraInformations = new List<Claim>();
                        extraInformations.Add(new Claim("hi","hello"));
                        await signInManager.SignInWithClaimsAsync(userModel, false, extraInformations);
                        return RedirectToAction("getInstructors", "Instructor");
                }
            }
            ModelState.AddModelError("", "Name & password Not Correct");
        }
        return View(userVM);
    }
        public async Task<IActionResult> signout()
        {
            await signInManager.SignOutAsync();//
            return RedirectToAction("Login");
        }
    }

}
