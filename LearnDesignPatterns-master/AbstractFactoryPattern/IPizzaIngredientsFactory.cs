using AbstractFactoryPattern.Ingredients.Interfaces;

namespace AbstractFactoryPattern
{
    public interface IPizzaIngredientsFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggies[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClam();

    }
}
