using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IModuleCompletionRepository
    {
        ModuleCompletion Add(ModuleCompletion completion);

        Task<IEnumerable<ModuleCompletion>> GetUserAsync(string userId);

        Task<bool> IsModuleCompletedByUserAsync(Guid moduleId, string userId);

        Task<ModuleCompletion> GetModuleCompletionAsync(Guid moduleId, string userId);

        void Update(ModuleCompletion completion);
        Task<IEnumerable<ModuleCompletion>> GetAllAsync();
    }
}
