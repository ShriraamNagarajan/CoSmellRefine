using CoSmellRefine.Models.Domain;

namespace CoSmellRefine.Models.ViewModels
{
    public class NotificationViewModel
    {
        public List<Notification> Notifications { get; set; }
        public int UnreadCount { get; set; }
    }
}
