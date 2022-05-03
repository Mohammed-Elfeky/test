using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StateController : Controller
    {
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("message", "My name is mohammed");
            HttpContext.Session.SetInt32("age", 26);
            return Content("Session  Saved");
        }
        public IActionResult GetSession()
        {
            string name = HttpContext.Session.GetString("message");
            int age = HttpContext.Session.GetInt32("age").Value;
            return Content($"msg={name} and age={age}");
        }

    }
}
