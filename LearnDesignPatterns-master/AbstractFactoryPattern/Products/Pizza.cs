using AbstractFactoryPattern.Ingredients.Interfaces;

namespace AbstractFactoryPattern.Product
{
    //Abstract Product
    public abstract class Pizza
    {
        private string name = string.Empty;
        public IDough? dough;
        public ISauce? sause;
        public ICheese? cheese;
        public IClams? clam;
        public IPepperoni? pepperoni;
        public IVeggies[]? veggies;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Baking for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Placing pizza in official PizzaStore box");
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
