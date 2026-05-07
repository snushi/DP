using AbstractFactoryPattern.Ingredients.Interfaces;

namespace AbstractFactoryPattern.Ingredients.Veggies
{
    internal class Onion : IVeggies
    {
        public Onion()
        {
            Console.WriteLine("Veggie -> Onion");

        }
    }
}