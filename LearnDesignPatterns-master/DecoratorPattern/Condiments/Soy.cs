namespace DecoratorPattern.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage): base(beverage)
        {
        }

        public override double Cost()
        {
            return 0.15 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
