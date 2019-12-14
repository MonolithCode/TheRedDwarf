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
            // This does not seem to be the correct endpoint
            return Redirect("https://accounts.google.com/Logout");
        }
    }
}