using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface IModuleRepository
    {
        Task<IEnumerable<Module>> GetAllAsync(string? searchQuery, string? sortBy, string? sortDirection, int pageNumber = 1, int pageSize = 100);
        Module? Get(Guid id);
        Module Add(Module module);
        Module? Update(Module module);
        Module? Delete(Guid id);
        int Count();
        string GetRecentlyUpdatedModule();
    }
}
