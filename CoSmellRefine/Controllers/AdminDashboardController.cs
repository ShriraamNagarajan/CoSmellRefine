using Microsoft.AspNetCore.Mvc;

namespace CoSmellRefine.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
