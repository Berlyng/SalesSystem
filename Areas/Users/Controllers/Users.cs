using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.Areas.Users.Controllers
{
    [Area("Users")]
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}
