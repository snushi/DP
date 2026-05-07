using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private readonly WeatherData _weatherData;

        public void Display()
        {
            Console.WriteLine($"Current Conditions {temperature}F degree and {humidity}% humidity");
        }
        public CurrentConditionDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update()
        {
            this.temperature = _weatherData.GetTemperature();
            this.humidity = _weatherData.GetHumidity();
            Display();
        }
    }
}
