using Isp.Compliance.Interface;
using Isp.Compliance;
using Isp.Violation.Interface;
using Isp.Violation;

namespace InterfaceSegregration
{
    internal class Program
    {
        static void Main()
        {
            ComplianceCase();
            ViolationCase();
        }


        private static void ComplianceCase()
        {
            IPrinter printer = new Printer();
            IScanner scanner = new Scanner();
            IPrinter photocopierAsPrinter = new Photocopier();
            IScanner photocopierAsScanner = new Photocopier();

            printer.Print();                
            scanner.Scan();               
            photocopierAsPrinter.Print();   
            photocopierAsScanner.Scan(); 
        }

        private static void ViolationCase()
        {
            IMultifunctionDevice printer = new MultifunctionPrinter();
            IMultifunctionDevice fax = new FaxMachine();

            printer.Print();
            printer.Scan();

            fax.Print();
            fax.Scan(); // Violating ISP, a fax machine doesn't need to implement the Scan method.
        }

    }
}
