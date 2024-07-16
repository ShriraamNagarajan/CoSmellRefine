using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoSmellRefine.Controllers
{
    [Authorize]
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
            var questionsByMonth = _questionRepository.GetDeveloperQuestionSummaryByMonth(user.Id);

            var viewModel = new DeveloperDashboardViewModel
            {
                ModuleCompletions = moduleCompletions,
                Notifications = notifications,
                RecentQuestions = recentQuestions,
                QuestionMonths = questionsByMonth.Select(q => q.MonthYear).ToList(),
                OpenQuestions = questionsByMonth.Select(q => q.OpenQuestions).ToList(),
                ClosedQuestions = questionsByMonth.Select(q => q.ClosedQuestions).ToList(),
            };

            return View(viewModel);
        }
    }
}
