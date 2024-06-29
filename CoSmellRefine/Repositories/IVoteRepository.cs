using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IVoteRepository
    {
        Task<IEnumerable<Vote>> GetAllAsync();
        Task<IEnumerable<Vote>> GetByResponseIdAsync(Guid responseId);
        Vote Add(Vote vote);
        Task<int> GetTotalVotesAsync(Guid responseId);
        Task<bool> IsResponseVotedByUserAsync(Guid responseId, string userId);

        Vote GetResponseVoteByUser(Guid responseId, string userId);
        void Update(Vote vote);

    }
}
