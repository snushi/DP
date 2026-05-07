using AbstractFactoryPattern.Ingredients.Interfaces;

namespace AbstractFactoryPattern.Ingredients.Clams
{
    public class FreshClams : IClams
    {
        public FreshClams()
        {
            Console.WriteLine("Clams -> Fresh Clams");

        }
    }
}