using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TheRedDwarf.Controllers
{
    public class AccountController : Controller
    {
        [Authorize]
        public IActionResult Authenticate()
        {
            return View();
        }
        
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return Redirect("https://www.google.com/accounts/Logout?continue=https://appengine.google.com/_ah/logout?continue=https://localhost:5001/Account/LoggedOut");
        }

        public IActionResult LoggedOut()
        {
            return View();
        }
    }
}