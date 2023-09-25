using OpenClosed.Compliance.Interface;

namespace OpenClosed.Compliance.Advertise
{
    // Create concrete discount strategy classes (extending the interface)
    class BlackFridayDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            // Apply a 20% discount for Black Friday
            return price * 0.8m;
        }
    }

}
