using Isp.Violation.Interface;

namespace Isp.Violation
{
    class FaxMachine : IMultifunctionDevice
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }
}
