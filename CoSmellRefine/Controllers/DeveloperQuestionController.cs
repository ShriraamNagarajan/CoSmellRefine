using CoSmellRefine.Hubs;
using CoSmellRefine.Models.Domain;
using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using CoSmellRefine.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace CoSmellRefine.Controllers
{
    public class DeveloperQuestionController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ICodeSmellRepository codeSmellRepository;
        private readonly IQuestionRepository questionRepository;
        private readonly IQuestionResponseRepository questionResponseRepository;
        private readonly IResponseCommentRepository responseCommentRepository;
        private readonly IReportIssueRepository reportIssueRepository;
        private readonly IRefactoringTechniqueRepository refactoringTechniqueRepository;
        private readonly IVoteRepository voteRepository;
        private readonly IHttpClientFactory _clientFactory;
        private readonly IHubContext<QuestionHub> questionHub;
        private readonly IMemoryCache memoryCache;

        public DeveloperQuestionController(ICodeSmellRepository codeSmellRepository, IQuestionRepository questionRepository, UserManager<IdentityUser> userManager, IQuestionResponseRepository questionResponseRepository, IResponseCommentRepository responseCommentRepository, IReportIssueRepository reportIssueRepository, IRefactoringTechniqueRepository refactoringTechniqueRepository, IVoteRepository voteRepository, IHttpClientFactory clientFactory, IHubContext<QuestionHub> questionHub, IMemoryCache memoryCache)
        {
            this.codeSmellRepository = codeSmellRepository;
            this.questionRepository = questionRepository;
            this.userManager = userManager;
            this.questionResponseRepository = questionResponseRepository;
            this.responseCommentRepository = responseCommentRepository;
            this.reportIssueRepository = reportIssueRepository;
            this.refactoringTechniqueRepository = refactoringTechniqueRepository;
            this.voteRepository = voteRepository;
            this._clientFactory = clientFactory;
            this.questionHub = questionHub;
            this.memoryCache = memoryCache;
            
        }
        public async Task<IActionResult> List(string? sortBy,
                                     string? questionType,
                                     string? filterType,
                                     int pageSize = 5,
                                     int pageNumber = 1)
        {
            var totalRecords = await questionRepository.CountAsync();
            var totalPages = Math.Ceiling((decimal)totalRecords / pageSize);

            if (pageNumber > totalPages)
            {
                pageNumber = (int)totalPages;
            }

            if (pageNumber < 1)
            {
                pageNumber = 1;
            }

            string? userId = null;
            if (!string.IsNullOrEmpty(filterType) && filterType == "MyQuestions")
            {
                //get the current user
                var user = await userManager.GetUserAsync(User);
                userId = user.Id;
            }


            var cacheKey = $"questions_{sortBy}_{questionType}_{filterType}_{pageSize}_{pageNumber}_{userId}";
            if (!memoryCache.TryGetValue(cacheKey, out IEnumerable<Question> questions))
            {
                // If not cached, get the data from the repository
                questions = await questionRepository.GetAllAsync(sortBy, questionType, userId, pageNumber, pageSize);
                foreach (var question in questions)
                {
                    question.Responses = (await questionResponseRepository.GetByQuestionId(question.Id)).ToList();
                }

                // Set cache options
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(1)) // Sliding expiration
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5)) // Absolute expiration
                    .SetPriority(CacheItemPriority.High); // Priority

                // Cache the data
                memoryCache.Set(cacheKey, questions, cacheEntryOptions);
            }


            var viewModel = new QuestionListModel
            {
                Questions = questions,
                TotalPages = (int)totalPages,
                PageNumber = pageNumber,
                PageSize = pageSize,
                SortBy = sortBy,
                QuestionType = questionType,
                FilterType = filterType
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> PostQuestion()
        {
            var codeSmells = await codeSmellRepository.GetAllAsync();
            var model = new QuestionViewModel
            {
                CodeSmells = codeSmells.Select(cs => new SelectListItem
                {
                    Value = cs.Id.ToString(),
                    Text = cs.Name
                }).ToList()
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> PostQuestion(QuestionViewModel model)
        {
            var codeSmells = await codeSmellRepository.GetAllAsync();
            if (ModelState.IsValid)
            {
                var selectedCodeSmells = codeSmells.Where(cs => model.SelectedCodeSmellIds.Contains(cs.Id)).ToList();

                //get the current user
                var user = await userManager.GetUserAsync(User);

                var question = new Question
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id,
                    Title = model.Title,
                    Body = model.Body,
                    CodeSnippet = model.CodeSnippet,
                    PostedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    Status = QuestionStatus.Open,
                    Type = model.Type,
                    IsDeleted = false,
                    CodeSmellList = selectedCodeSmells,
                    Images = model.ImageUrls.Select(url => new QuestionImage { ImageUrl = url }).ToList() // Using image URLs
                };

                questionRepository.Add(question);
                TempData["success"] = "Question has been posted successfully";
                return RedirectToAction(nameof(Index)); 
            }
            TempData["failure"] = "An issue in posting the question";
            model.CodeSmells = codeSmells.Select(cs => new SelectListItem
            {
                Value = cs.Id.ToString(),
                Text = cs.Name
            }).ToList();
            return View(model);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var question = questionRepository.Get(id);
            var user = await userManager.GetUserAsync(User);
            if (question == null)
            {
                return NotFound();
            }

            var responses = (await questionResponseRepository.GetByQuestionId(id)).Select(r => new QuestionResponseViewModel
            {
                Id = r.Id,
                User = r.User,
                Body = r.Body,
                CodeSnippet = r.CodeSnippet,
                PostedDate = r.PostedDate,
                IsDeleted = r.IsDeleted,
                VoteCount = r.Votes.Count(v => v.IsUpvote) - r.Votes.Count(v => !v.IsUpvote),
                RefactoringTechniques = r.RefactoringTechniques.ToList(),
                CodeSmellList = r.CodeSmellList.ToList(),
                ResponseComments = responseCommentRepository.GetByResponseId(r.Id),
                VoteByUser = voteRepository.GetResponseVoteByUser(r.Id, user.Id)
             
            }).ToList();

            //create issue model
            CreateIssueViewModel createIssueModel = null;
            var claims = await userManager.GetClaimsAsync(user);
            var accessToken = claims.FirstOrDefault(c => c.Type == "access_token")?.Value;

            if (accessToken != null)
            {
                var client = _clientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("CoSmellRefine", "1.0"));

                var response = await client.GetStringAsync("https://api.github.com/user/repos");
                var repositories = JsonSerializer.Deserialize<List<Repository>>(response);

                if (repositories != null && repositories.Count > 0)
                {
                    var firstRepoFullName = repositories.First().full_name;
                    var owner = firstRepoFullName.Split('/')[0];

                    var repoSelectList = repositories.Select(repo => new SelectListItem
                    {
                        Value = repo.full_name,
                        Text = repo.name
                    }).ToList();

                    createIssueModel = new CreateIssueViewModel
                    {
                        Repo = repositories.First().full_name,
                        Owner = owner,
                        Repositories = repoSelectList
                    };
                }
            }


            var viewModel = new QuestionDetailViewModel
            {
                Question = question,
                Responses = responses,
                AddResponseComment = new AddResponseCommentViewModel(),
                AddReportIssue = new AddReportIssueViewModel(),
                AddResponse = new AddResponseViewModel
                {
                    QuestionId = id,
                    CodeSmells = (await codeSmellRepository.GetAllAsync()).Select(cs => new SelectListItem
                    {
                        Value = cs.Id.ToString(),
                        Text = cs.Name
                    }).ToList(),
                    RefactoringTechniques = (await refactoringTechniqueRepository.GetAllAsync()).Select(rt => new SelectListItem
                    {
                        Value = rt.Id.ToString(),
                        Text = rt.Name
                    }).ToList()
                },
                CreateIssue = createIssueModel ?? new CreateIssueViewModel()
            };

            return View(viewModel);

        }

        [HttpPost]
        public async Task<IActionResult> AddComment(AddResponseCommentViewModel addResponseComment)
        {
            
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }

            var responseComment = new ResponseComment
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                ResponseId = addResponseComment.ResponseId,
                CommentDate = DateTime.UtcNow,
                IsDeleted = false,
                Body = addResponseComment.Body
            };

            responseCommentRepository.Add(responseComment);
            // Broadcast the new comment to other clients
            await questionHub.Clients.All.SendAsync("CommentAdded", new
            {
                Id = responseComment.Id,
                UserId = user.Id,
                ResponseId = addResponseComment.ResponseId,
                CommentDate = responseComment.CommentDate,
                IsDeleted = responseComment.IsDeleted,
                Body = addResponseComment.Body,
                UserName = user.UserName,
                QuestionId = addResponseComment.QuestionId
            });
            return RedirectToAction("Details", new { id = addResponseComment.QuestionId});
        }

        [HttpPost]
        public async Task<IActionResult> AddReportIssue([FromBody] AddReportIssueViewModel model)
        {


            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }

            var reportIssue = new ReportIssue
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                DiscussionItemId = model.DiscussionItemId,
                Reason = model.Reason,
                DiscussionType = model.DiscussionType,
                ReportDate = DateTime.UtcNow,
                Status = ReportIssueStatus.InReview,
                StatusReason = "Currently in review"
            };

            reportIssueRepository.Add(reportIssue);
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> AddResponse(AddResponseViewModel model)
        {
           
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }
            var codeSmells = codeSmellRepository.GetByIds(model.SelectedCodeSmellIds);
            var refactoringTechniques = refactoringTechniqueRepository.GetByIds(model.SelectedRefactoringTechniqueIds);

            var questionResponse = new QuestionResponse
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                QuestionId = model.QuestionId,
                Body = model.Body,
                CodeSnippet = model.CodeSnippet,
                PostedDate = DateTime.UtcNow,
                IsDeleted = false,
                CodeSmellList = codeSmells.ToList(),
                RefactoringTechniques = refactoringTechniques.ToList()
            };

            questionResponseRepository.Add(questionResponse);


            await questionHub.Clients.All.SendAsync("ResponseAdded", new
            {
                Id = questionResponse.Id,
                UserId = user.Id,
                QuestionId = model.QuestionId,
                Body = model.Body,
                CodeSnippet = model.CodeSnippet,
                PostedDate = questionResponse.PostedDate,
                IsDeleted = questionResponse.IsDeleted,
                CodeSmellList = codeSmells.Select(cs => new { cs.Id, cs.Name }),
                RefactoringTechniques = refactoringTechniques.Select(rt => new { rt.Id, rt.Name }),
                UserName = user.UserName
            });

            return RedirectToAction("Details", new { id = model.QuestionId });
        }



        public async Task<IActionResult> CloseQuestion(Guid id)
        {
            var question = questionRepository.Get(id);
            question.Status = QuestionStatus.Closed;
            questionRepository.Update(question);
            await questionHub.Clients.All.SendAsync("QuestionClosed", id);
            return RedirectToAction("Details", new { id = id });
        }

        [HttpGet]
        public async Task<IActionResult> GetFinalAnswer(Guid questionId)
        {
            // Fetch the responses for the given question ID
            var responses = await questionResponseRepository.GetByQuestionId(questionId);

            if (responses == null || !responses.Any())
            {
                return Json(new { success = false, message = "No responses found for the given question ID." });
            }

            // Rank responses based on the vote count
            var rankedResponses = responses
                .Select(r => new
                {
                    Response = r,
                    VoteCount = r.Votes.Count(v => v.IsUpvote) - r.Votes.Count(v => !v.IsUpvote)
                })
                .OrderByDescending(r => r.VoteCount)
                .ToList();

            // Get the top-ranked response
            var topResponse = rankedResponses.FirstOrDefault();

            if (topResponse == null)
            {
                return Json(new { success = false, message = "No valid responses found for the given question ID." });
            }

            // Get the question
            var question = questionRepository.Get(questionId);
            if (question == null)
            {
                return Json(new { success = false, message = "Question not found." });
            }

            // Annotate the question's code snippet with the top response
            var annotatedCodeSnippet = AnnotateCodeSnippet(
                                            question.CodeSnippet,
                                            topResponse.Response.Body,
                                            topResponse.Response.CodeSnippet,
                                            topResponse.Response.CodeSmellList,
                                            topResponse.Response.RefactoringTechniques
                                        );


            return Json(new { success = true, codeSnippet = annotatedCodeSnippet });
        }

        private string AnnotateCodeSnippet(
       string codeSnippet,
       string responseBody,
       string responseCodeSnippet,
       ICollection<CodeSmell> codeSmellList,
       ICollection<RefactoringTechnique> refactoringTechniques)
        {
            var annotatedSnippet = new StringBuilder();

            annotatedSnippet.AppendLine("// Top Answer:");
            annotatedSnippet.AppendLine($"// Body: {responseBody}");
            annotatedSnippet.AppendLine($"// Code Snippet: {responseCodeSnippet}");
            annotatedSnippet.AppendLine("// Code Smells: " + string.Join(", ", codeSmellList.Select(cs => cs.Name)));
            annotatedSnippet.AppendLine("// Refactoring Techniques: " + string.Join(", ", refactoringTechniques.Select(rt => rt.Name)));
            annotatedSnippet.AppendLine(codeSnippet);

            return annotatedSnippet.ToString();
        }


        [HttpPost]
        public async Task<IActionResult> CreateIssue([FromBody] CreateIssueViewModel issueModel)
        {
            var user = await userManager.GetUserAsync(User);
            var claims = await userManager.GetClaimsAsync(user);
            var accessToken = claims.FirstOrDefault(c => c.Type == "access_token")?.Value;

            if (accessToken == null)
            {
                return Unauthorized();
            }

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("CoSmellRefine", "1.0"));

            var issue = new
            {
                title = issueModel.Title,
                body = issueModel.Body
            };

            var url = $"https://api.github.com/repos/{issueModel.Repo}/issues";
            var response = await client.PostAsJsonAsync(url, issue);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                return StatusCode((int)response.StatusCode, errorContent);
            }

            return Ok();
        }







    }
}
