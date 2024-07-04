using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoSmellRefine.Controllers
{
    public class DeveloperDashboardController : Controller
    {
        private readonly IModuleCompletionRepository _moduleCompletionRepository;
        private readonly INotificationRepository _notificationRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public DeveloperDashboardController(IModuleCompletionRepository moduleCompletionRepository,
        INotificationRepository notificationRepository,
        IQuestionRepository questionRepository, UserManager<IdentityUser> userManager)
        {
            _moduleCompletionRepository = moduleCompletionRepository;
            _notificationRepository = notificationRepository;
            _questionRepository = questionRepository;
            _userManager = userManager;

        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            var moduleCompletions = await _moduleCompletionRepository.GetUserAsync(user.Id);
            var notifications = await _notificationRepository.GetUserAsync(user.Id);
            var recentQuestions = await _questionRepository.GetRecentQuestionsAsync(user.Id);

            var viewModel = new DeveloperDashboardViewModel
            {
                ModuleCompletions = moduleCompletions,
                Notifications = notifications,
                RecentQuestions = recentQuestions
            };

            return View(viewModel);
        }
    }
}
