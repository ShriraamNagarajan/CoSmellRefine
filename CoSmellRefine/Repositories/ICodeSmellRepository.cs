using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface ICodeSmellRepository
    {
        Task<IEnumerable<CodeSmell>> GetAllAsync();

        Task<CodeSmell?> GetAsync(Guid id);

        Task<int> CountAsync();

        IEnumerable<CodeSmell> GetByIds(IEnumerable<Guid> ids);
    }
}
