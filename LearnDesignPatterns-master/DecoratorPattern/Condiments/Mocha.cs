
namespace DecoratorPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }        

        public override string GetDescription()
        {           
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
