 
namespace OpenClosed.Compliance.Interface
{
    interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal price);
    }
}
