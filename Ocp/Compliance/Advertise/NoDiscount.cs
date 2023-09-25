
using OpenClosed.Compliance.Interface;
namespace OpenClosed.Compliance.Advertise
{
    class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            // No discount applied
            return price;
        }
    }


}
