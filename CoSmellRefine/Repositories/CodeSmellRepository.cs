using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class CodeSmellRepository : ICodeSmellRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CodeSmellRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<IEnumerable<CodeSmell>> GetAllAsync()
        {
            return await dbContext.CodeSmells
                .Include(x => x.CodeSmellCategory)
                .Include(x => x.RefactoringTechniqueList)
                .ToListAsync();

        }

        public async Task<CodeSmell?> GetAsync(Guid id)
        {
            return await dbContext.CodeSmells
            .Include(x => x.CodeSmellCategory)
            .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> CountAsync()
        {
            return await dbContext.CodeSmells.CountAsync();
        }

        public IEnumerable<CodeSmell> GetByIds(IEnumerable<Guid> ids)
        {
            return dbContext.CodeSmells.Where(cs => ids.Contains(cs.Id)).ToList();
        }
    }
}
