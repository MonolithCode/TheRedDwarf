using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TheRedDwarf.Controllers
{
    public class AuthenticationController : Controller
    {
        [Authorize]
        public IActionResult TestAuthentication()
        {
            return View();
        }
        
        public IActionResult TestSignOut()
        {
            HttpContext.SignOutAsync();
            return Redirect("https://accounts.google.com/Logout");
        }
    }
}