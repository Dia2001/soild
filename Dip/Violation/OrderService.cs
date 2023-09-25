using DependencyInversion.Violation.Entities;

namespace DependencyInversion.Violation
{
    internal class OrderService
    {
        public void ProcessOrder(Order order)
        {
            // Order process
                // Do something

            // Send notification by mail
            EmailService mailService = new EmailService();
            mailService.SendEmail(order.CustomerEmail, "The order has been processed");
        }
    }
}
