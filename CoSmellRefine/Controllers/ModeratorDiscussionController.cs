using CoSmellRefine.Models.Domain;
using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoSmellRefine.Controllers
{
    public class ModeratorDiscussionController : Controller
    {
        private readonly IQuestionRepository questionRepository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public ModeratorDiscussionController(IQuestionRepository questionRepository,
            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.questionRepository = questionRepository;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpGet]
        [ActionName("List")]
        public async Task<IActionResult> List(
              string? searchQuery,
              string? sortBy,
              string? sortDirection,
              int pageSize = 3,
              int pageNumber = 1)
        {
            var totalRecords = await questionRepository.CountAsync();
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

            var discussionList = await questionRepository.GetAllAsync(searchQuery, sortBy, sortDirection, pageNumber, pageSize);


            var moderatorDiscussionViewModels = discussionList.Select(q => new ModeratorDiscussionViewModel
                                                {
                                                    Id = q.Id,
                                                    User = q.User,
                                                    Title = q.Title,
                                                    Status = q.Status,
                                                    Type = q.Type,
                                                    PostedDate = q.PostedDate,
                                                    NumOfResponses = q.Responses.Count
                                                }).ToList();

            return View(moderatorDiscussionViewModels);
        }
    }
}
