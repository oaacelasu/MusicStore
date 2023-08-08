using Microsoft.AspNetCore.Mvc;

namespace MusicStore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}