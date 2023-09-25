using DependencyInversion.Compliance.Interface;

namespace DependencyInversion.Compliance.Services
{
    class NotificationService : INotificationService
    {
        public void SendEmail(string recipient, string message)
        { 
            Console.WriteLine($"Đã gửi email đến {recipient}: {message}");
        }
    }
}
