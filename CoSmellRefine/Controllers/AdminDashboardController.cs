using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoSmellRefine.Controllers
{
    [Authorize]
    public class AdminDashboardController : Controller
    {
        private readonly IModuleCompletionRepository _moduleCompletionRepository;
        private readonly IModuleRepository _moduleRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IQuestionResponseRepository _questionResponseRepository;
        private readonly IQuizResultsRepository _quizResultsRepository;
        private readonly IUserRepository _userRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public AdminDashboardController(IQuestionResponseRepository questionResponseRepository, IModuleCompletionRepository moduleCompletionRepository, IQuestionRepository questionRepository, IQuizResultsRepository quizResultsRepository, UserManager<IdentityUser> userManager, IUserRepository userRepository, IModuleRepository moduleRepository)
        {
            _questionRepository = questionRepository;
            _quizResultsRepository = quizResultsRepository;
            _userManager = userManager;
            _moduleCompletionRepository = moduleCompletionRepository;
            _questionResponseRepository = questionResponseRepository;
            _userRepository = userRepository;
            _moduleRepository = moduleRepository;
        }





        public async Task<IActionResult> IndexAsync()
        {
            var totalUsers = await _userRepository.CountAsync();
            var totalQuestions = await _questionRepository.CountAsync();
            var totalModules = _moduleRepository.Count();
            var topContributors = _questionResponseRepository.GetTopContributors(4);
            var moduleCompletions = await _moduleCompletionRepository.GetAllAsync();
            var questionsByMonth = _questionRepository.GetQuestionSummaryByMonth();
            var quizResults = _quizResultsRepository.GetAverageQuizResults();
            var viewModel = new AdminDashboardViewModel
            {
                TotalUsers = totalUsers,
                TotalQuestionsPosted = totalQuestions,
                TotalModules = totalModules,
                RecentlyUpdatedModule = _moduleRepository.GetRecentlyUpdatedModule(),
                TopContributors = topContributors.Select(tc => tc.UserName).ToList(),
                Contributions = topContributors.Select(tc => tc.Count).ToList(),
                ModuleCompletions = moduleCompletions,
                QuestionMonths = questionsByMonth.Select(q => q.MonthYear).ToList(),
                OpenQuestions = questionsByMonth.Select(q => q.OpenQuestions).ToList(),
                ClosedQuestions = questionsByMonth.Select(q => q.ClosedQuestions).ToList(),
                QuizResultModules = quizResults.Select(qr => qr.ModuleName).ToList(),
                AverageQuizResults = quizResults.Select(qr => qr.AverageResult).ToList()
            };
            return View(viewModel);
        }
    }
}
