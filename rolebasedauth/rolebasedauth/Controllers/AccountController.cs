using Microsoft.AspNetCore.Mvc;

namespace rolebasedauth.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult signUp()
        {
            return View();
        }public IActionResult logIn()
        {
            return View();
        }
    }
}
