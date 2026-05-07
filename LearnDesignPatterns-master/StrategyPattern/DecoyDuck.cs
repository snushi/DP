using StrategyPattern.Algorithms;

namespace StrategyPattern
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new MuteQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Looks like a decoy duck");
        }
    }
}
