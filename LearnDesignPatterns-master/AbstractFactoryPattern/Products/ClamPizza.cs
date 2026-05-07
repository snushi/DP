namespace AbstractFactoryPattern.Product
{
    public class ClamPizza : Pizza
    {
        IPizzaIngredientsFactory _ingredientsFactory;
        public ClamPizza(IPizzaIngredientsFactory ingredientsFactory)
        {
            _ingredientsFactory = ingredientsFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {GetName()}");
            dough = _ingredientsFactory.CreateDough();
            sause = _ingredientsFactory.CreateSauce();
            cheese = _ingredientsFactory.CreateCheese();
            clam = _ingredientsFactory.CreateClam();
        }
    }
}
