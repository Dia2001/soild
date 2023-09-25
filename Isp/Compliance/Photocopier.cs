using Isp.Compliance.Interface;

namespace Isp.Compliance
{
    internal class Photocopier : IPrinter, IScanner
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