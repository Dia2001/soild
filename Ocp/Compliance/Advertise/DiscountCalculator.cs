using OpenClosed.Compliance.Entities;
using OpenClosed.Compliance.Interface;

namespace OpenClosed.Compliance.Advertise
{
    internal class DiscountCalculator
    {
        private readonly IDiscountStrategy discountStrategy;

        public DiscountCalculator(IDiscountStrategy strategy)
        {
            discountStrategy = strategy;
        }

        public decimal CalculateDiscountedPrice(Product product)
        {
            return discountStrategy.ApplyDiscount(product.Price);
        }
    }
}
