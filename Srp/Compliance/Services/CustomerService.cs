using Srp.Compliance.Entities;

namespace Srp.Compliance.Services
{
    internal class CustomerService
    {
        public void SaveCustomer(Customer c)
        { 
            File.WriteAllText($"{c.Name}.txt", c.Name);
        }
    }
}
