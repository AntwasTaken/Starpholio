using Microsoft.AspNetCore.Mvc;
using Starpholio.Models;

public class SignupController : Controller
{
    private readonly AuthService _authService;

    public SignupController(AuthService authService)
    {
        _authService = authService;
    }

    // GET: Signup
    public ActionResult Index()
    {
        return View();
    }

    // POST: Signup
    [HttpPost]
    public ActionResult Index(SignupModel model)
    {
        if (ModelState.IsValid)
        {
            // Perform additional signup logic, such as creating a new user in the database
            // and redirect to a success page or perform a login operation
            // You can access the signup form data via the model properties
            // For example: model.Username, model.Password, model.TwoFactorAuthentication

            return RedirectToAction("Success");
        }

        return View(model);
    }

    // GET: Signup/Success
    public ActionResult Success()
    {
        return View();
    }
}
