 

namespace OpenClosed
{
    internal class Program
    {
        static void Main()
        {
            ViolationCase();
            ComplianceCase(); 
        }
         
        private static void ViolationCase()
        {
            var laptop = new Violation.Entities.Product("Laptop", 1000m);
            var tshirt = new Violation.Entities.Product("Áo thun", 20m);

            var discountCalculator = new Violation.DiscountCalculator();

            decimal laptopPriceWithDiscount = discountCalculator.CalculateDiscountedPrice(laptop);
            decimal tshirtPriceWithDiscount = discountCalculator.CalculateDiscountedPrice(tshirt);

            Console.WriteLine($"Giá laptop sau giảm giá: ${laptopPriceWithDiscount}");
            Console.WriteLine($"Giá áo thun sau giảm giá: ${tshirtPriceWithDiscount}");
        }

        private static void ComplianceCase()
        {
            // Create product instances
            var laptop = new Compliance.Entities.Laptop("Gaming Laptop", 1000m);
            var tshirt = new Compliance.Entities.TShirt("Cool T-Shirt", 20m);

            // Create discount calculators with different discount strategies
            var blackFridayDiscountCalculator = new Compliance.Advertise.DiscountCalculator(new Compliance.Advertise.BlackFridayDiscount());
            var noDiscountCalculator = new Compliance.Advertise.DiscountCalculator(new Compliance.Advertise.NoDiscount());

            // Calculate discounted prices without modifying existing code
            decimal laptopPriceWithDiscount = blackFridayDiscountCalculator.CalculateDiscountedPrice(laptop);
            decimal tshirtPriceWithDiscount = noDiscountCalculator.CalculateDiscountedPrice(tshirt);

            Console.WriteLine($"Laptop price with discount: ${laptopPriceWithDiscount}");
            Console.WriteLine($"T-Shirt price with discount: ${tshirtPriceWithDiscount}");
        }

    }
}
