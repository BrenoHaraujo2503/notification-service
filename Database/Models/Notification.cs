using notification_service.Enums;

namespace notification_service.database.models
{
    public class Notification
    {
        public Guid Id { get; set; }

        public NotificationChannel channel;

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime? ReadAt { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
