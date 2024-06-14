using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IModuleVideoRepository
    {
        Task<IEnumerable<ModuleVideo>> GetAllAsync();

        Task<IEnumerable<ModuleVideo>> GetByModuleIdAsync(Guid moduleId);

        Task<ModuleVideo?> GetAsync(Guid id);

        ModuleVideo Add(ModuleVideo video);

        Task<ModuleVideo?> UpdateAsync(ModuleVideo video);

        Task<ModuleVideo?> DeleteAsync(Guid id);

        Task<int> CountAsync();
    }
}
