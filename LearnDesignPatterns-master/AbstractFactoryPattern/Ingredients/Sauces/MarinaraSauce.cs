using AbstractFactoryPattern.Ingredients.Interfaces;

namespace AbstractFactoryPattern.Ingredients.Sauces
{
    internal class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            Console.WriteLine("Sauce -> Marinara source");

        }
    }
}