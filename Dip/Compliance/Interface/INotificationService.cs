namespace DependencyInversion.Compliance.Interface
{
    interface INotificationService
    {
        void SendEmail(string recipient, string message);
    }
}
