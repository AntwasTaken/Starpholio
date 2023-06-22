using Microsoft.AspNetCore.Mvc;
using Starpholio.Models;

namespace Starpholio.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        // GET: Auth/Signup
        public ActionResult Signup()
        {
            return View();
        }

        // POST: Auth/Signup
        [HttpPost]
        public ActionResult Signup(SignupModel model)
        {
            // Implement your signup logic here

            return RedirectToAction("Login");
        }

        // GET: Auth/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Auth/Login
        [HttpPost]
        public ActionResult Login(LoginSys model)
        {
            if (ModelState.IsValid)
            {
                if (_authService.Login(model.Username, model.Password))
                {
                    // Authentication successful, perform additional actions
                    return RedirectToAction("Dashboard", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }

            return View(model);
        }
    }
}
