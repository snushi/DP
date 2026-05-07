
namespace StrategyPattern.Algorithms
{
    public class QuackQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Quack >>");
        }       
    }
}
