
namespace DecoratorPattern.Coffee
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "HouseBlend";
        }
        public override double Cost()
        {
            return 0.89;
        }

        public override string GetDescription()
        {
            return "HouseBlend Coffee";
        }
    }
}
