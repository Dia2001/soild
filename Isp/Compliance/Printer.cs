using Isp.Compliance.Interface;

namespace Isp.Compliance
{
    internal class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }
    }
}