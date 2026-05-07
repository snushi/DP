
namespace StrategyPattern.Algorithms
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Squeak >>");
        }
    }
}
