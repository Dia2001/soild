
using OpenClosed.Compliance.Interface;

namespace OpenClosed.Compliance.Advertise
{
    internal class WomensDayDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            // Apply a 20% discount for Black Friday
            return price * 1.3m;
        }
    }
}
