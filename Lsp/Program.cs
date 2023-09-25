
 
namespace LiskovSubtitution
{
    class Program
    {
        static void Main()
        {
            // Vi phạm
            ViolationCase();

            // Tuân thủ
            // ComplianceCase();
        }

        private static void ViolationCase()
        {
            Lsp.Violation.Bird bird = new Lsp.Violation.Ostrich();
            bird.Fly();
        }

        private static void ComplianceCase()
        {
            Lsp.Compliance.Interface.IFlyable flyingBird = new Lsp.Compliance.Entities.Sparrow();
            Lsp.Compliance.Entities.Bird ostrichBird = new Lsp.Compliance.Entities.Ostrich();

            flyingBird.Fly();  // In ra "This sparrow can fly." 
            // You cannot call ostrichBird.Fly() for ostrichBird because the Ostrich does not implement IFlyable.
            // ostrichBird.Fly();
        }

    }

}
