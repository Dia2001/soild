

namespace Srp.Violation
{
    internal class Customer
    {
        public string Name { get; set; }
        public void SaveCustomer()
        { 
            File.WriteAllText($"{Name}.txt", Name);
        }
        public void SendConfirmationEmail()
        { 
            Console.WriteLine($"Gửi email xác nhận cho {Name}");
        }
    }
}
