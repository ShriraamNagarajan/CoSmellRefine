using Microsoft.AspNetCore.Mvc;

namespace CoSmellRefine.Controllers
{
    public class ModeratorDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
