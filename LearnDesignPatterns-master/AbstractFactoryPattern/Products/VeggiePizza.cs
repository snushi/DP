using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Product
{
    internal class VeggiePizza : Pizza
    {
        IPizzaIngredientsFactory _ingredientsFactory;
        public VeggiePizza(IPizzaIngredientsFactory ingredientsFactory)
        {
            _ingredientsFactory = ingredientsFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {GetName()}");
            dough = _ingredientsFactory.CreateDough();
            sause = _ingredientsFactory.CreateSauce();
            cheese = _ingredientsFactory.CreateCheese();
            veggies = _ingredientsFactory.CreateVeggies();
        }
    }
}
