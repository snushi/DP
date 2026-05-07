
namespace DecoratorPattern.Condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return 0.10 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", SteamedMilk";
        }
    }
}
