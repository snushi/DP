using AbstractFactoryPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Creator
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza;

            IPizzaIngredientsFactory ingredientFactory = new NYPizzaIngredientsFactory();

            if (item.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("New York Style Cheese Pizza");
            }            
            else if (item.Equals("clam", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("New York Style Clam Pizza");
            }
            else if (item.Equals("veggie", StringComparison.OrdinalIgnoreCase))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("New York Style Veggie Pizza");
            }
            else
            {
                 throw new ArgumentException("Invalid pizza type");
            }

            return pizza;

        }
    }
}
