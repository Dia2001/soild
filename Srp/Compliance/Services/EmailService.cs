 

namespace Srp.Compliance.Services
{
    internal class EmailService
    {
        public void SendConfirmationEmail(string customerName)
        { 
            Console.WriteLine($"Gửi email xác nhận cho {customerName}");
        }
    }
}
