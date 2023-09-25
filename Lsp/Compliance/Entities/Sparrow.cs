
using Lsp.Compliance.Interface;

namespace Lsp.Compliance.Entities
{
    class Sparrow : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("This sparrow can fly.");
        }
    }
}
