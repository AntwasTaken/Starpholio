using Microsoft.AspNetCore.Mvc;

namespace Starpholio.Controllers
{
    public class Categories : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
