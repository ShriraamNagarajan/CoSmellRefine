using Microsoft.AspNetCore.Mvc;

namespace CoSmellRefine.Controllers
{
    public class DeveloperDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
