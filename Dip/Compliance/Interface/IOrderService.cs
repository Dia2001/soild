using DependencyInversion.Violation.Entities;

namespace DependencyInversion.Compliance.Interface
{
    interface IOrderService
    {
        void ProcessOrder(Order o);
    }
}
