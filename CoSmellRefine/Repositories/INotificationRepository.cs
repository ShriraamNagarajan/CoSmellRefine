using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Repositories
{
    public interface INotificationRepository
    {
        Task<IEnumerable<Notification>> GetAllAsync();

        Task<IEnumerable<Notification>> GetUserAsync(string userId);

        Task<Notification?> GetAsync(Guid id);

        Task<int> CountAsync();

        Task<int> CountUnreadAsync(string userId);

        void Update(Notification notification);
    }
}
