namespace FactoryPattern.ProductClasses
{
    //Abstract Product
    public abstract class Pizza
    {
        public string name = string.Empty;
        public string dough = string.Empty;
        public string sause = string.Empty;
        public List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (var topping in toppings)
            {
                Console.WriteLine($"   {topping}");
            }
        }

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

        public string GetName()
        {
            return name;
        }
    }
}
