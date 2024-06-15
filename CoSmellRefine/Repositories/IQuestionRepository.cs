using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<Question>> GetAllAsync(string? searchQuery, string? sortBy, string? sortDirection, int pageNumber = 1, int pageSize = 100);
        Question? Get(Guid id);

        Task<int> CountAsync();
    }
}
