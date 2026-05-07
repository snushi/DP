using AbstractFactoryPattern.Ingredients.Interfaces;

namespace AbstractFactoryPattern.Ingredients.Veggies
{
    internal class Garlic : IVeggies
    {
        public Garlic()
        {
            Console.WriteLine("Veggie -> Garlic");

        }
    }
}