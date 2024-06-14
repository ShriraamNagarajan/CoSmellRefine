using CoSmellRefine.Data;
using CoSmellRefine.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoSmellRefine.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly ApplicationDbContext dbContext;

        public NotificationRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Notification>> GetAllAsync()
        {
            return await dbContext.Notifications.ToListAsync();

        }


        public async Task<IEnumerable<Notification>> GetUserAsync(string userId)
        {
            return await dbContext.Notifications
                            .Where(n => n.UserId == userId)
                            .ToListAsync();
        }


        public async Task<Notification?> GetAsync(Guid id)
        {
            return await dbContext.Notifications.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> CountAsync()
        {
            return await dbContext.Notifications.CountAsync();
        }

        public async Task<int> CountUnreadAsync(string userId)
        {
            return await dbContext.Notifications.Where(n => n.UserId == userId && !n.IsRead).CountAsync();
        }

        public void Update(Notification notification)
        {
            dbContext.Notifications.Update(notification);
            dbContext.SaveChanges();
        }
    }
}
