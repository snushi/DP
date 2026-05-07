using AbstractFactoryPattern.Ingredients.Interfaces;

namespace AbstractFactoryPattern.Ingredients.Cheese
{
    public class ReggianoCheese : ICheese
    {
        public ReggianoCheese()
        {
            Console.WriteLine("Chesse -> Reggiano Cheese");
        }
    }
}
