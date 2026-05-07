using AbstractFactoryPattern.Ingredients.Interfaces;

namespace AbstractFactoryPattern.Ingredients.Veggies
{
    internal class RedPepper : IVeggies
    {
        public RedPepper()
        {
            Console.WriteLine("Veggie -> RedPepper");
        }
    }
}