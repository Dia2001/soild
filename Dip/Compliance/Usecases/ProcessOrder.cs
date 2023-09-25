using DependencyInversion.Compliance.Interface;
using DependencyInversion.Violation.Entities;

namespace DependencyInversion.Compliance.Usecases
{
    internal class ProcessOrders
    {
        INotificationService notificationService;
        IOrderService orderService;
        public ProcessOrders(INotificationService _notificationService, IOrderService _orderService)
        {
            notificationService = _notificationService;
            orderService = _orderService;
        }

        public void ProcessOrder(Order order)
        {
            // Process Order
            orderService.ProcessOrder(order);
            // Send notification
            notificationService.SendEmail(order.CustomerEmail, "The order has been processed");
        }
    }
}
