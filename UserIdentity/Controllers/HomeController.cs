using Microsoft.AspNetCore.Mvc;

namespace UserIdentity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
