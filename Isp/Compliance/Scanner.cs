using Isp.Compliance.Interface;

namespace Isp.Compliance
{
    internal class Scanner : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }
}