using CoSmellRefine.Hubs;
using CoSmellRefine.Models.Domain;
using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using CoSmellRefine.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Controllers
{
    [Authorize]
    public class ModeratorIssueController : Controller
    {
        private readonly IReportIssueRepository reportIssueRepository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IQuestionRepository questionRepository;
        private readonly IQuestionResponseRepository questionResponseRepository;
        private readonly IResponseCommentRepository responseCommentRepository;
        private readonly INotificationRepository notificationRepository;
        private readonly IHubContext<QuestionHub> questionHub;

        public ModeratorIssueController(IReportIssueRepository reportIssueRepository,
            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IQuestionRepository questionRepository, IQuestionResponseRepository questionResponseRepository, IResponseCommentRepository responseCommentRepository, INotificationRepository notificationRepository, IHubContext<QuestionHub> questionHub)
        {
            this.reportIssueRepository = reportIssueRepository;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.questionRepository = questionRepository;
            this.questionResponseRepository = questionResponseRepository;
            this.responseCommentRepository = responseCommentRepository;
            this.notificationRepository = notificationRepository;
            this.questionHub = questionHub;
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

                string userId = null;

                // Get the respective content based on the Type attribute and extract the user ID
                switch (issueDetails.DiscussionType)
                {
                    case DiscussionType.Question:
                        var question = questionRepository.Get(issueDetails.DiscussionItemId);
                        if (question != null)
                        {
                            userId = question.UserId;
                        }
                        break;
                    case DiscussionType.Response:
                        var questionResponse = questionResponseRepository.Get(issueDetails.DiscussionItemId);
                        if (questionResponse != null)
                        {
                            userId = questionResponse.UserId;
                        }
                        break;
                    case DiscussionType.ResponseComment:
                        var responseComment = responseCommentRepository.Get(issueDetails.DiscussionItemId);
                        if (responseComment != null)
                        {
                            userId = responseComment.UserId;
                        }
                        break;
                    default:
                        throw new InvalidOperationException("Unknown issue type.");
                }

                if (userId != null)
                {
                    // Create and send the notification
                    var notification = new Notification
                    {
                        Id = Guid.NewGuid(),
                        UserId = userId,
                        Message = "You have been warned due to inappropriate content.",
                        SentTime = DateTime.UtcNow,
                        IsRead = false
                    };

                    notificationRepository.Add(notification);
                }



                //update the issue
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
                //remove the content
                switch (issueDetails.DiscussionType)
                {
                    case DiscussionType.Question:
                        await questionRepository.DeleteAsync(issueDetails.DiscussionItemId);
                        await questionHub.Clients.All.SendAsync("ContentRemoved", issueDetails.DiscussionItemId, "Question");
                        break;
                    case DiscussionType.Response:
                        await questionResponseRepository.DeleteAsync(issueDetails.DiscussionItemId);
                        await questionHub.Clients.All.SendAsync("ContentRemoved", issueDetails.DiscussionItemId, "Response");
                        break;
                    case DiscussionType.ResponseComment:
                        await responseCommentRepository.DeleteAsync(issueDetails.DiscussionItemId);
                        await questionHub.Clients.All.SendAsync("ContentRemoved", issueDetails.DiscussionItemId, "ResponseComment");
                        break;
                    default:
                        // Handle unknown type or throw an exception
                        throw new InvalidOperationException("Unknown issue type.");
                }

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
                var updatedIssue = await reportIssueRepository.UpdateAsync(reportIssue);
                if (updatedIssue != null)
                {
                    // Show success notification
                    TempData["success"] = "The issue has been succesfully updated";
                    return RedirectToAction("List");
                }

            }
            TempData["error"] = "Failed to update the issue";
            return RedirectToAction("Details", new { id = issueDetails.Id });

        }

        [HttpGet]
        public IActionResult ViewReferencedItem(Guid discussionItemId, string discussionType)
        {
            Guid questionId;

            switch (discussionType)
            {
                case DiscussionType.Question:
                    questionId = discussionItemId;
                    break;
                case DiscussionType.Response:
                    var response = questionResponseRepository.Get(discussionItemId);
                    if (response == null)
                    {
                        return NotFound();
                    }
                    questionId = (Guid)response.QuestionId;
                    break;
          
                default:
                    return BadRequest("Invalid discussion type.");
            }

            return RedirectToAction("Details", "DeveloperQuestion", new { id = questionId });
        }

    }
}
