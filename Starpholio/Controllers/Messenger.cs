using Microsoft.AspNetCore.Mvc;

namespace Starpholio.Controllers
{
    public class Messenger : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
