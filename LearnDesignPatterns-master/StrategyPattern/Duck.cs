using StrategyPattern.Algorithms;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public IFlyBehavior? flyBehaviour;
        public IQuackBehavior? quackBehaviour;
        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("All duck swim");
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehaviour = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehaviour = qb;
        }   

        public void PerformFly()
        {
            flyBehaviour?.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour?.Quack();
        }   
    }
}
