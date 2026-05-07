using AbstractFactoryPattern.Ingredients.Interfaces;

namespace AbstractFactoryPattern.Ingredients.Veggies
{
    internal class Mushroom : IVeggies
    {
        public Mushroom()
        {
            Console.WriteLine("Veggie -> Mushroom");

        }
    }
}