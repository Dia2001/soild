 
namespace SingleResponsibility
{
    internal class Program
    {
        static void Main()
        { 
            // Vi phạm
            ViolationCase();

            // Tuân thủ
            // ComplianceCase();
        } 

        private static void ViolationCase()
        {
            var customer = new Srp.Violation.Customer { Name = "John" }; 
            customer.SaveCustomer();
            customer.SendConfirmationEmail();
        }

        private static void ComplianceCase()
        {
            var customer = new Srp.Compliance.Entities.Customer { Name = "John" };
            var emailService = new Srp.Compliance.Services.EmailService();
            var customerService = new Srp.Compliance.Services.CustomerService();
            // Lưu thông tin khách hàng
            customerService.SaveCustomer(customer);

            // Gửi email xác nhận
            emailService.SendConfirmationEmail(customer.Name);
        }
    }
}
