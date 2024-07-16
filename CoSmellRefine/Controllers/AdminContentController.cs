using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Controllers
{
    [Authorize]
    public class AdminContentController : Controller
    {
        private readonly IModuleRepository moduleRepository;
        private readonly ICodeSmellRepository codeSmellRepository;
        private readonly IModuleVideoRepository moduleVideoRepository;
        private readonly IFlashcardRepository flashcardRepository;
        private readonly IQuizRepository quizRepository;
        private readonly ApplicationDbContext _context;

        public AdminContentController(IModuleRepository moduleRepository, ICodeSmellRepository codeSmellRepository, IModuleVideoRepository moduleVideoRepository, IFlashcardRepository flashcardRepository, IQuizRepository quizRepository, ApplicationDbContext context)
        {
            this.moduleRepository = moduleRepository;
            this.codeSmellRepository = codeSmellRepository;
            this.moduleVideoRepository = moduleVideoRepository;
            this.flashcardRepository = flashcardRepository;
            this.quizRepository = quizRepository;
            this._context = context;
        }


        public async Task<IActionResult> Add()
        {
            var model = new ModuleViewModel
            {
                CodeSmells = await codeSmellRepository.GetAllAsync()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(ModuleViewModel model)
        {

            if (ModelState.IsValid)
            {
                var codesmell = await codeSmellRepository.GetAsync(model.CodeSmellId);
                var module_id = Guid.NewGuid();
                var module = new Module
                {
                    Id = module_id,
                    CodeSmellId = model.CodeSmellId,
                    CodeSmellCategoryId = codesmell.CodeSmellCategory.Id,
                    Title = model.Title,
                    Description = model.Description,
                    ReadingContent = model.ReadingContent,
                    LastModifiedDate = DateTime.UtcNow,
                    Videos = model.VideoUrls.Select(url => new ModuleVideo
                    {
                        Id = Guid.NewGuid(),
                        VideoUrl = url,
                        ModuleId = module_id
                    }).ToList(),
                    Flashcards = model.Flashcards.Select(f => new Flashcard
                    {
                        Id = Guid.NewGuid(),
                        Question = f.Question,
                        Answer = f.Answer,
                        ModuleId = module_id
                    }).ToList(),
                    Quizzes = model.Quizzes.Select(q => new Quiz
                    {
                        Id = Guid.NewGuid(),
                        Question = q.Question,
                        Choices = string.Join(",", q.Choices),
                        Answer = q.Answer,
                        ModuleId = module_id
                    }).ToList()
                };

                moduleRepository.Add(module);
                //show success notification
                TempData["success"] = "Module has been added successfully";
                return RedirectToAction("List", "AdminContent");
            }
            //show error notification
            TempData["error"] = "Failed to add module";
            return View(model);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var module = moduleRepository.Get(id);

            if (module == null)
            {
                return NotFound();
            }

            var model = new ModuleViewModel
            {
                Id = module.Id,
                CodeSmellId = module.CodeSmellId,
                Title = module.Title,
                Description = module.Description,
                ReadingContent = module.ReadingContent,
                VideoUrls = module.Videos.Select(v => v.VideoUrl).ToList(),
                Flashcards = module.Flashcards.Select(f => new FlashcardViewModel { Question = f.Question, Answer = f.Answer }).ToList(),
                Quizzes = module.Quizzes.Select(q => new QuizViewModel
                {
                    Question = q.Question,
                    Choices = q.Choices.Split(',').ToList(),
                    Answer = q.Answer
                }).ToList(),
                CodeSmells = await _context.CodeSmells.ToListAsync()
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ModuleViewModel model)
        {

            if (ModelState.IsValid)
            {

                var newmodule = new Module
                {
                    Id = model.Id,
                    CodeSmellId = model.CodeSmellId,
                    Title = model.Title,
                    Description = model.Description,
                    ReadingContent = model.ReadingContent,
                    LastModifiedDate = DateTime.UtcNow
                };

                moduleRepository.Update(newmodule);


                // Add new videos to the repository
                foreach (var url in model.VideoUrls)
                {
                    var video = new ModuleVideo
                    {
                        Id = Guid.NewGuid(),
                        VideoUrl = url,
                        ModuleId = model.Id
                    };
                    moduleVideoRepository.Add(video);
                }

                // Add new flashcards to the repository
                foreach (var f in model.Flashcards)
                {
                    var flashcard = new Flashcard
                    {
                        Id = Guid.NewGuid(),
                        Question = f.Question,
                        Answer = f.Answer,
                        ModuleId = model.Id
                    };
                    flashcardRepository.Add(flashcard);
                }

                // Add new quizzes to the repository
                foreach (var q in model.Quizzes)
                {
                    var quiz = new Quiz
                    {
                        Id = Guid.NewGuid(),
                        Question = q.Question,
                        Choices = string.Join(",", q.Choices),
                        Answer = q.Answer,
                        ModuleId = model.Id
                    };
                    quizRepository.Add(quiz);
                }


                //show success notification
                TempData["success"] = "Module has been updated successfully";
                return RedirectToAction("List", "AdminContent");
            }

            // Reload code smells in case of error
            //show errror notification
            TempData["error"] = "Failed to update module";
            model.CodeSmells = await codeSmellRepository.GetAllAsync(); 
            return View(model);
        }


        [HttpGet]
        [ActionName("List")]
        public async Task<IActionResult> ListAsync(
                   string? searchQuery,
                   string? sortBy,
                   string? sortDirection,
                   int pageSize = 3,
                   int pageNumber = 1)
        {
            var totalRecords = moduleRepository.Count();
            var totalPages = Math.Ceiling((decimal)totalRecords / pageSize);

            if (pageNumber > totalPages)
            {
                pageNumber--;
            }

            if (pageNumber < 1)
            {
                pageNumber++;
            }


            ViewBag.TotalPages = totalPages;
            ViewBag.SearchQuery = searchQuery;
            ViewBag.SortBy = sortBy;
            ViewBag.SortDirection = sortDirection;
            ViewBag.PageSize = pageSize;
            ViewBag.PageNumber = pageNumber;

            var blogs = await moduleRepository.GetAllAsync(searchQuery, sortBy, sortDirection, pageNumber, pageSize);

            return View(blogs);
        }

        #region API Calls

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var deletedModule = moduleRepository.Delete(id);

            if (deletedModule != null)
            {
                // Show success notification
                TempData["success"] = "Module has been deleted successfully";
                return Json(new { success = true, message = "Deleted Successfully" });

            }

            // Show an error notification
            TempData["error"] = "Failed to delete the module.";

            return Json(new { success = false, message = "Error while deleting" });
        }
        #endregion


    }
}
