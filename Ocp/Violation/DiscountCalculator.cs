 

namespace OpenClosed.Violation
{
    internal class DiscountCalculator
    {
        public decimal CalculateDiscountedPrice(Entities.Product product)
        {
            // The current source code only supports 10% discount for all products
            return product.Price * 0.9m;
        }
    }
}
