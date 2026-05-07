using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private float temperature;
        private float humidity;
        private float pressure;

        public List<IObserver> observers = new List<IObserver>();

        public float GetTemperature()
        {
            return temperature;
        }

        public float GetHumidity()
        {
            return humidity;
        } 

        public float GetPressure()
        {
            return pressure;
        }


        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }
        
        public WeatherData() { }
        public void NotifyObservers()
        {
            foreach(var obs in observers)
            {
                obs.Update();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
