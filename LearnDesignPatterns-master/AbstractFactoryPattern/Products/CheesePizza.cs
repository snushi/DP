namespace AbstractFactoryPattern.Product
{
    public class CheesePizza : Pizza
    {
        IPizzaIngredientsFactory _ingredientsFactory;

        public CheesePizza(IPizzaIngredientsFactory ingredientsFactory)
        {
            _ingredientsFactory = ingredientsFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {GetName()}");

            dough = _ingredientsFactory.CreateDough();
            sause = _ingredientsFactory.CreateSauce();
            cheese = _ingredientsFactory.CreateCheese();
        }
    }
}
