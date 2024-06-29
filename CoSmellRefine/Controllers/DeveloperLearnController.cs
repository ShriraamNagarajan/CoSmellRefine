using CoSmellRefine.Models.Domain;
using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Controllers
{
    public class DeveloperLearnController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IModuleRepository moduleRepository;
        private readonly ICodeSmellCategoryRepository codeSmellCategoryRepository;
        private readonly IQuizResultsRepository quizResultsRepository;
        private readonly IModuleCompletionRepository moduleCompletionRepository;
        public DeveloperLearnController(UserManager<IdentityUser> userManager, IModuleRepository moduleRepository, ICodeSmellCategoryRepository codeSmellCategoryRepository, IQuizResultsRepository quizResultsRepository, IModuleCompletionRepository moduleCompletionRepository)
        {
            this.userManager = userManager;
            this.moduleRepository = moduleRepository;
            this.codeSmellCategoryRepository = codeSmellCategoryRepository;
            this.quizResultsRepository = quizResultsRepository;
            this.moduleCompletionRepository = moduleCompletionRepository;


        }
        public async Task<IActionResult> Index()
        {
            //get the current user
            var user = await userManager.GetUserAsync(User);

            //compute the total modules, completed modules, and average quiz result
            var totalModules = 23; //need to change this from magic number
            var completedModules = await moduleCompletionRepository.GetUserAsync(user.Id);
            var quizzes = await quizResultsRepository.GetUserAsync(user.Id);
            var categories = await codeSmellCategoryRepository.GetAllAsync();
            var count = await codeSmellCategoryRepository.CountAsync();

            var completedModulesCount = completedModules.Count();
            var averageQuizScore = quizzes.Any() ? quizzes.Average(q => q.Result) : 0;
            averageQuizScore = Math.Round(averageQuizScore, 2, MidpointRounding.AwayFromZero);

            var completedCategoriesCount = categories.Count(c => c.Modules.All(m => completedModules.Any(cm => cm.ModuleId == m.Id)));
            var totalCategories = count;
            var progress = totalCategories > 0 ? (double)completedCategoriesCount / totalCategories : 0;

            var quizScores = quizzes.Select(q => q.Result).ToList();
            var quizDates = quizzes.Select(q => q.CompletedDate.Date).ToList();

            var viewModel = new LearnDashboardViewModel
            {
                CompletedModules = completedModulesCount,
                TotalModules = totalModules,
                AverageQuizScore = averageQuizScore,
                Progress = progress,
                QuizScores = quizScores,
                QuizDates = quizDates
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Modules()
        {
            var categories = await codeSmellCategoryRepository.GetAllAsync();

            //get the current user
            var user = await userManager.GetUserAsync(User);

            // Get the completed modules for the current user
            var completedModules = await moduleCompletionRepository.GetUserAsync(user.Id);

            // Create the view model list
            var categoryViewModels = categories.Select(category => new CategoryViewModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                ImageUrl = category.ImageUrl,
                IsCompleted = category.Modules.All(module => completedModules.Any(completed => completed.ModuleId == module.Id))
            }).ToList();

            // Pass the view model to the view
            return View(categoryViewModels);
        }

        public async Task<IActionResult> Submodules(Guid id)
        {
            //get the category
            var category = await codeSmellCategoryRepository.GetAsync(id);
            //get the modules
            var modules = category.Modules;

            //get the current user
            var user = await userManager.GetUserAsync(User);
            // Get the completed modules for the current user

            var completedModules = await moduleCompletionRepository.GetUserAsync(user.Id);

            // Create the view model list
            var submoduleViewModels = modules.Select(module => new SubmoduleViewModel
            {
                Id = module.Id,
                Title = module.Title,
                Description = module.Description,
                IsCompleted = completedModules.Any(completed => completed.ModuleId == module.Id)
            }).ToList();

            // Pass the view model to the view
            return View(submoduleViewModels);
        }
        public async Task<IActionResult> InteractiveLearning(Guid id)
        {
            //get the curren module
            var module = moduleRepository.Get(id);
            //get the current user
            var user = await userManager.GetUserAsync(User);

            // Check if the module is completed by the user
            var isCompleted = await moduleCompletionRepository.IsModuleCompletedByUserAsync(id, user.Id);
            var quizResults = isCompleted ? await quizResultsRepository.GetQuizResultsAsync(id, user.Id) : new QuizResults();


            // Map the module to module view model
            var moduleViewModel = new DeveloperModuleViewModel
            {
                Id = module.Id,
                CodeSmellId = module.CodeSmellId,
                Title = module.Title,
                Description = module.Description,
                ReadingContent = module.ReadingContent,
                VideoUrls = module.Videos.Select(v => v.VideoUrl).ToList(),
                Flashcards = module.Flashcards.Select(f => new FlashcardViewModel
                {
                    Question = f.Question,
                    Answer = f.Answer
                }).ToList(),
                Quizzes = module.Quizzes.Select(q => new QuizViewModel
                {
                    Question = q.Question,
                    Choices = q.Choices.Split(',').ToList(), 
                    Answer = q.Answer
                }).ToList(),
                IsCompleted = isCompleted,
                QuizResults = quizResults
            };

            // Pass to the view page
            return View(moduleViewModel);

        }


        [HttpPost]
        public async Task<IActionResult> SubmitQuizResults([FromBody] QuizSubmissionModel model)
        {
            var user = await userManager.GetUserAsync(User);

            // Check for existing quiz results
            var existingQuizResults = await quizResultsRepository.GetQuizResultsAsync(model.ModuleId, user.Id);
            if (existingQuizResults == null)
            {
                // Add new quiz results if none exist
                var newQuizResults = new QuizResults
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id,
                    ModuleId = model.ModuleId,
                    CompletedDate = DateTime.UtcNow,
                    Result = model.QuizResult
                };
                quizResultsRepository.Add(newQuizResults);
            }
            else
            {
                // Update existing quiz results
                existingQuizResults.Result = model.QuizResult;
                existingQuizResults.CompletedDate = DateTime.UtcNow;
                quizResultsRepository.Update(existingQuizResults);
            }

            // Check for existing module completion
            var existingModuleCompletion = await moduleCompletionRepository.GetModuleCompletionAsync(model.ModuleId, user.Id);
            if (existingModuleCompletion == null)
            {
                // Add new module completion if none exist
                var newModuleCompletion = new ModuleCompletion
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id,
                    ModuleId = model.ModuleId,
                    CompletedDate = DateTime.UtcNow
                };
                moduleCompletionRepository.Add(newModuleCompletion);
            }
           
    

            var module = moduleRepository.Get(model.ModuleId);
            var categoryId = module.CodeSmellCategory.Id;

            return Json(new { success = true, redirectUrl = Url.Action("Submodules", "DeveloperLearn", new { id = categoryId }) });
        }

    }
}
