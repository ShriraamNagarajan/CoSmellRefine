using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IRefactoringTechniqueRepository
    {
        Task<IEnumerable<RefactoringTechnique>> GetAllAsync();

        Task<RefactoringTechnique?> GetAsync(Guid id);

        Task<int> CountAsync();

        IEnumerable<RefactoringTechnique> GetByIds(IEnumerable<Guid> ids);
    }
}
