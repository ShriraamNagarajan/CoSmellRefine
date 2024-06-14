using Azure;
using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface ICodeSmellCategoryRepository
    {
        Task<IEnumerable<CodeSmellCategory>> GetAllAsync();

        Task<CodeSmellCategory?> GetAsync(Guid id);

        Task<int> CountAsync();
    }
}
