using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AppSklepZoologiczny.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class AppUserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManger;

        public AppUserController(UserManager<IdentityUser> userManger)
        {
            _userManger = userManger;
        }

        public IActionResult Index()
        {
            var users = _userManger.Users;
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
