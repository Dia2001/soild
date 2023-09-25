namespace DependencyInversion
{
    internal class Program
    {
        static void Main()
        {
            // Violation case
            Violation.OrderService orderService = new Violation.OrderService();
            Violation.Entities.Order o = new Violation.Entities.Order();
            orderService.ProcessOrder(o);

            // Compliance
            Compliance.Services.NotificationService notiService = new Compliance.Services.NotificationService();
            Compliance.Services.OrderService os = new Compliance.Services.OrderService();
            Compliance.Usecases.ProcessOrders po = new Compliance.Usecases.ProcessOrders(notiService, os);
            po.ProcessOrder(o);
        }
    }
}
