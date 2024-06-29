using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class VoteRepository : IVoteRepository
    {
        private readonly ApplicationDbContext dbContext;

        public VoteRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Vote Add(Vote vote)
        {
            dbContext.Add(vote);
            dbContext.SaveChanges();
            return vote;
        }


        public async Task<IEnumerable<Vote>> GetAllAsync()
        {

            return await dbContext.Votes.ToListAsync();
        }

        public async Task<IEnumerable<Vote>> GetByResponseIdAsync(Guid responseId)
        {
            return await dbContext.Votes
                .Where(vote => vote.ResponseId == responseId)
                .ToListAsync();
        }

        public async Task<int> GetTotalVotesAsync(Guid responseId)
        {
            var upvotes = await dbContext.Votes
                .CountAsync(vote => vote.ResponseId == responseId && vote.IsUpvote);

            var downvotes = await dbContext.Votes
                .CountAsync(vote => vote.ResponseId == responseId && !vote.IsUpvote);

            return upvotes - downvotes;
        }


        public async Task<bool> IsResponseVotedByUserAsync(Guid responseId, string userId)
        {
            return await dbContext.Votes
                .AnyAsync(mc => mc.ResponseId == responseId && mc.UserId == userId);
        }


        public Vote GetResponseVoteByUser(Guid responseId, string userId)
        {
            return dbContext.Votes
                .FirstOrDefault(qr => qr.ResponseId == responseId && qr.UserId == userId);
        }

        public void Update(Vote vote)
        {
            dbContext.Votes.Update(vote);
            dbContext.SaveChanges();
        }

    }
}
