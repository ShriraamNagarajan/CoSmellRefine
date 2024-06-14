using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class ModuleVideoRepository : IModuleVideoRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ModuleVideoRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public ModuleVideo Add(ModuleVideo video)
        {
            dbContext.Add(video);
            dbContext.SaveChanges();
            return video;
        }

        public async Task<ModuleVideo?> DeleteAsync(Guid id)
        {
            var existingVideo = await dbContext.ModuleVideos.FindAsync(id);

            if (existingVideo != null)
            {
                dbContext.ModuleVideos.Remove(existingVideo);
                await dbContext.SaveChangesAsync();
                return existingVideo;
            }

            return null;
        }

        public async Task<IEnumerable<ModuleVideo>> GetAllAsync()
        {

            return await dbContext.ModuleVideos.ToListAsync();
        }

        public async Task<IEnumerable<ModuleVideo>> GetByModuleIdAsync(Guid moduleId)
        {
            return await dbContext.ModuleVideos
                .Where(moduleVideo => moduleVideo.ModuleId == moduleId)
                .ToListAsync();
        }



        public async Task<ModuleVideo?> GetAsync(Guid id)
        {
            return await dbContext.ModuleVideos
            .Include(x => x.Module)
            .FirstOrDefaultAsync(x => x.Id == id);

        }


        public async Task<ModuleVideo?> UpdateAsync(ModuleVideo video)
        {
            var existingVideo = await dbContext.ModuleVideos.Include(x => x.Module)
                .FirstOrDefaultAsync(x => x.Id == video.Id);

            if (existingVideo != null)
            {
                existingVideo.Id = video.Id;
                existingVideo.VideoUrl = video.VideoUrl;
                await dbContext.SaveChangesAsync();
                return existingVideo;
            }

            return null;
        }

        public async Task<int> CountAsync()
        {
            return await dbContext.ModuleVideos.CountAsync();
        }

  
    }
}
