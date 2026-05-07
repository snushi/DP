using FactoryPattern.ProductClasses;

namespace FactoryPattern.CreatorClasses
{
    //Concrete Creator
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza? pizza = null;

            if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new NYStyleCheesePizza();
            }
            else
            {
                throw new ArgumentException("Invalid pizza type: " + type);
            }

            // Additional pizza types can be added here
            return pizza;
        }
    }
}
