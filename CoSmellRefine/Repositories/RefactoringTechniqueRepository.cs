using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class RefactoringTechniqueRepository : IRefactoringTechniqueRepository
    {
        private readonly ApplicationDbContext dbContext;

        public RefactoringTechniqueRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<IEnumerable<RefactoringTechnique>> GetAllAsync()
        {
            return await dbContext.RefactoringTechniques.ToListAsync();

        }

        public async Task<RefactoringTechnique?> GetAsync(Guid id)
        {
            return await dbContext.RefactoringTechniques
            .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> CountAsync()
        {
            return await dbContext.RefactoringTechniques.CountAsync();
        }

        public IEnumerable<RefactoringTechnique> GetByIds(IEnumerable<Guid> ids)
        {
            return dbContext.RefactoringTechniques.Where(rt => ids.Contains(rt.Id)).ToList();
        }
    }
}
