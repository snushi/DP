using AbstractFactoryPattern.Ingredients.Interfaces;

namespace AbstractFactoryPattern.Ingredients.Daughs
{
    internal class ThinCrustDough : IDough
    {
        public ThinCrustDough()
        {
            Console.WriteLine("Dough -> Thin crust dough");

        }
    }
}