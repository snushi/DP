namespace FactoryPattern.ProductClasses
{
    //Concrete Product
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sause = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
