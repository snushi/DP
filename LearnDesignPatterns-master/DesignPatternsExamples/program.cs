using DecoratorPattern;
using DecoratorPattern.Coffee;
using DecoratorPattern.Condiments;
using FactoryPattern.CreatorClasses;
using FactoryPattern.ProductClasses;
using ObserverPattern;
using StrategyPattern;
using StrategyPattern.Algorithms;

namespace DesignPatternsExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Observer Pattern Example

            //WeatherData weatherData = new WeatherData(); //Subject

            //IObserver currentDisplay = new CurrentConditionDisplay(weatherData); //Observer

            //weatherData.SetMeasurements(80, 65, 30.4f);
            //weatherData.SetMeasurements(76, 80, 34.4f);

            //Strategy Pattern Example

            #endregion

            #region Strategy Pattern Example

            //MallardDuck mallard = new();

            //mallard.Display();
            //mallard.PerformQuack();
            //mallard.PerformFly();

            //DecoyDuck decoy = new();

            //decoy.Display();
            //decoy.PerformQuack();
            //decoy.PerformFly();

            //decoy.SetFlyBehavior(new FlyWithWings());
            //decoy.SetQuackBehavior(new Squeak());

            //decoy.PerformQuack();
            //decoy.PerformFly();

            #endregion

            #region Decorator Pattern Example

            //Double mocha soy latte with whip

            //Beverage beverage = new HouseBlend();

            //beverage = new Mocha(beverage);
            //beverage = new Mocha(beverage);
            //beverage = new Soy(beverage);
            //beverage = new Whip(beverage);

            //Console.WriteLine(beverage.GetDescription() + " " + beverage.Cost() + "$");

            //Beverage beverage1 = new DarkRoast();
            //beverage1 = new Mocha(beverage1);
            //beverage1 = new Mocha(beverage1);
            //beverage1 = new Whip(beverage1);

            //Console.WriteLine(beverage1.GetDescription() + " " + beverage1.Cost() + "$");

            #endregion

            #region Factory Pattern Example

            //PizzaStore nyStore = new NYPizzaStore();

            //nyStore.OrderPizza("cheese");

            #endregion

            #region Abstract Factory Pattern Example

            AbstractFactoryPattern.Creator.PizzaStore nyPizzaStore = new AbstractFactoryPattern.Creator.NYPizzaStore();
            //nyPizzaStore.OrderPizza("cheese");
            //nyPizzaStore.OrderPizza("clam");
            nyPizzaStore.OrderPizza("veggie");


            #endregion

            // You can add more design pattern examples here

        }

    }
}
