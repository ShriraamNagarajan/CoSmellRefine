using CoSmellRefine.Hubs;
using CoSmellRefine.Models.Domain;
using CoSmellRefine.Models.ViewModels;
using CoSmellRefine.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IVoteRepository voteRepository;
        private readonly IHubContext<QuestionHub> questionHub;

        public VoteController(IVoteRepository voteRepository, UserManager<IdentityUser> userManager, IHubContext<QuestionHub> questionHub)
        {
            this.voteRepository = voteRepository;
            this.userManager = userManager;
            this.questionHub = questionHub;
        }


        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddVote([FromBody] AddVoteViewModel addVote)
        {
            var user = await userManager.GetUserAsync(User);

            var isExisting = await voteRepository.IsResponseVotedByUserAsync(addVote.ResponseId, user.Id);
            if (isExisting)
            {
                var existingVote = voteRepository.GetResponseVoteByUser(addVote.ResponseId, user.Id);
                existingVote.VoteDate = DateTime.UtcNow;
                existingVote.IsUpvote = addVote.IsUpvote;
                voteRepository.Update(existingVote);

            }
            else
            {
                var vote = new Vote
                {
                    ResponseId = addVote.ResponseId,
                    UserId = user.Id,
                    IsUpvote = addVote.IsUpvote,
                    VoteDate = DateTime.UtcNow
                };

                var result = voteRepository.Add(vote);

            }
            var totalVotes = await voteRepository.GetTotalVotesAsync(addVote.ResponseId);
            await questionHub.Clients.All.SendAsync("VoteUpdated", addVote.ResponseId, totalVotes);


            return Ok();
        }

        [HttpGet]
        [Route("{responseId:Guid}/totalVotes")]
        public async Task<IActionResult> GetTotalVotesForResponse([FromRoute] Guid responseId)
        {
            var totalVotes = await voteRepository.GetTotalVotesAsync(responseId);
            return Ok(totalVotes);
        }
    }
}
