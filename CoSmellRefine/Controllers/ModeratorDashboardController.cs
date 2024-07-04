using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoSmellRefine.Controllers
{
    public class ModeratorDashboardController : Controller
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly INotificationRepository _notificationRepository;
        private readonly IReportIssueRepository _reportIssueRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public ModeratorDashboardController(IQuestionRepository questionRepository, INotificationRepository notificationRepository, IReportIssueRepository reportIssueRepository, UserManager<IdentityUser> userManager)
        {
            _questionRepository = questionRepository;
            _notificationRepository = notificationRepository;
            _reportIssueRepository = reportIssueRepository;
            _userManager = userManager;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            var recentQuestions = await _questionRepository.GetRecentQuestionsAsync();
            var notifications = await _notificationRepository.GetUserAsync(user.Id);
            var discussionSummary = _questionRepository.GetQuestionsPerMonth();
            var reportIssueSummary = _reportIssueRepository.GetIssuesPerMonth();

            var viewModel = new ModeratorDashboardViewModel
            {
                RecentQuestions = recentQuestions,
                Notifications = notifications,
                DiscussionSummary = discussionSummary,
                ReportIssueSummary = reportIssueSummary,
            };
            return View(viewModel);
        }
    }
}
