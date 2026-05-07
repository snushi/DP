
namespace StrategyPattern.Algorithms
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }    
    }
}
