using AbstractFactoryPattern.Ingredients.Cheese;
using AbstractFactoryPattern.Ingredients.Clams;
using AbstractFactoryPattern.Ingredients.Daughs;
using AbstractFactoryPattern.Ingredients.Interfaces;
using AbstractFactoryPattern.Ingredients.Pepporoni;
using AbstractFactoryPattern.Ingredients.Sauces;
using AbstractFactoryPattern.Ingredients.Veggies;

namespace AbstractFactoryPattern
{
    public class NYPizzaIngredientsFactory : IPizzaIngredientsFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClam()
        {
            return new FreshClams();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            return new IVeggies[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }
    }
}
