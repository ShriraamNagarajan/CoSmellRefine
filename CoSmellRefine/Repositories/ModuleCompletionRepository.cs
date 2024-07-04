using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class ModuleCompletionRepository : IModuleCompletionRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ModuleCompletionRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public ModuleCompletion Add(ModuleCompletion completion)
        {
            dbContext.Add(completion);
            dbContext.SaveChanges();
            return completion;
        }

        public async Task<IEnumerable<ModuleCompletion>> GetAllAsync()
        {
            return await dbContext.ModuleCompletion
                            .ToListAsync();
        }


        public async Task<IEnumerable<ModuleCompletion>> GetUserAsync(string userId)
        {
            return await dbContext.ModuleCompletion
                            .Where(n => n.UserId == userId)
                            .ToListAsync();
        }

        public async Task<bool> IsModuleCompletedByUserAsync(Guid moduleId, string userId)
        {
            return await dbContext.ModuleCompletion
                .AnyAsync(mc => mc.ModuleId == moduleId && mc.UserId == userId);
        }


        public void Update(ModuleCompletion completion)
        {
            dbContext.ModuleCompletion.Update(completion);
            dbContext.SaveChanges();
        }

        public async Task<ModuleCompletion> GetModuleCompletionAsync(Guid moduleId, string userId)
        {
            return await dbContext.ModuleCompletion
                .Include(x => x.Module)
                .Include(x => x.User)
                .FirstOrDefaultAsync(qr => qr.ModuleId == moduleId && qr.UserId == userId);
        }

    }
}
