using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using CoSmellRefine.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoSmellRefine.Controllers
{
    public class ModeratorIssueController : Controller
    {
        private readonly IReportIssueRepository reportIssueRepository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public ModeratorIssueController(IReportIssueRepository reportIssueRepository,
            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.reportIssueRepository = reportIssueRepository;
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
            var totalRecords = await reportIssueRepository.CountAsync();
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

            var reportIssueList = await reportIssueRepository.GetAllAsync(searchQuery, sortBy, sortDirection, pageNumber, pageSize);
            return View(reportIssueList);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            // Retrieve the result from the repository
            var issue = await reportIssueRepository.GetAsync(id);

            if (issue != null)
            {
                // map the domain model into the view model
                var model = new ReportIssueDetails
                {
                    Id = issue.Id,
                    User = issue.User,
                    DiscussionItemId = issue.DiscussionItemId,
                    Reason = issue.Reason,
                    ReportDate = issue.ReportDate,
                    Status = issue.Status,
                    StatusReason = issue.StatusReason,
                    DiscussionType = issue.DiscussionType
                };
                return View(model);
            }

            // pass data to view
            return View(null);

        }


        [HttpPost]
        public async Task<IActionResult> WarnUser(ReportIssueDetails issueDetails)
        {
            var reportIssue = await reportIssueRepository.GetAsync(issueDetails.Id);
            if (reportIssue != null)
            {
                reportIssue.Status = ReportIssueStatus.WarnedUser;
                reportIssue.StatusReason = issueDetails.StatusReason;
                //need to send notification to the user to warn the user
                var updatedIssue = await reportIssueRepository.UpdateAsync(reportIssue);
                if (updatedIssue != null)
                {
                    // Show success notification
                    TempData["success"] = "The user has been successfully warned";
                    return RedirectToAction("List");
                }

            }
            TempData["error"] = "Failed to warn the user";
            return RedirectToAction("Details", new { id = issueDetails.Id });

        }

        [HttpPost]
        public async Task<IActionResult> RemoveContent(ReportIssueDetails issueDetails)
        {
            var reportIssue = await reportIssueRepository.GetAsync(issueDetails.Id);
            if (reportIssue != null)
            {
                reportIssue.Status = ReportIssueStatus.ContentRemoved;
                reportIssue.StatusReason = issueDetails.StatusReason;
                //need to remove the content
                var updatedIssue = await reportIssueRepository.UpdateAsync(reportIssue);
                if (updatedIssue != null)
                {
                    // Show success notification
                    TempData["success"] = "The content has been successfully removed";
                    return RedirectToAction("List");
                }

            }
            TempData["error"] = "Failed to remove the content";
            return RedirectToAction("Details", new { id = issueDetails.Id });

        }

        [HttpPost]
        public async Task<IActionResult> NoActionNeeded(ReportIssueDetails issueDetails)
        {
            var reportIssue = await reportIssueRepository.GetAsync(issueDetails.Id);
            if (reportIssue != null)
            {
                reportIssue.Status = ReportIssueStatus.NoActionNeeded;
                reportIssue.StatusReason = issueDetails.StatusReason;
                //need to remove the content
                var updatedIssue = await reportIssueRepository.UpdateAsync(reportIssue);
                if (updatedIssue != null)
                {
                    // Show success notification
                    TempData["success"] = "The issue has been succesfully updated";
                    return RedirectToAction("List");
                }

            }
            TempData["error"] = "Failed to update teh issue";
            return RedirectToAction("Details", new { id = issueDetails.Id });

        }

    }
}
