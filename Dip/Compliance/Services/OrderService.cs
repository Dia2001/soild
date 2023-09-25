using DependencyInversion.Compliance.Interface;
using DependencyInversion.Violation.Entities;

namespace DependencyInversion.Compliance.Services
{
    class OrderService : IOrderService
    {
        public void ProcessOrder(Order o)
        {
            Console.WriteLine("Do something !"); 
        }
    }
}
