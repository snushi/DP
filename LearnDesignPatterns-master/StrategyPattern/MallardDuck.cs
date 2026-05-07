using StrategyPattern.Algorithms;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new QuackQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a mallard duck");
        }
    }
}
