namespace DependencyInversion.Violation
{
    internal class EmailService
    {
        public void SendEmail(string recipient, string message)
        {
            Console.WriteLine($"Đã gửi email đến {recipient}: {message}");
        }
    }
}
