using AbstractFactoryPattern.Ingredients.Interfaces;

namespace AbstractFactoryPattern.Ingredients.Pepporoni
{
    internal class SlicedPepperoni : IPepperoni
    {
        public SlicedPepperoni()
        {
            Console.WriteLine("Pepperoni -> Sliced pepperoni");

        }
    }
}