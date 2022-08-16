using Microsoft.AspNetCore.Mvc;

namespace UserIdentity.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
