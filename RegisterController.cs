using Microsoft.AspNetCore.Mvc;
using register.Models;

namespace register.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(register user)
        {
            if (ModelState.IsValid)
            {
                return Content(
                    $"Registration Successful\nName: {user.Name}\nEmail: {user.Email}\nPassword: {user.Password}\nAge: {user.Age)");
            }
            return View(user);
        }
    }
}

    }
}
