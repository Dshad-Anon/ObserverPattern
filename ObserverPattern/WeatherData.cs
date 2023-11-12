using ObserverPattern.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class WeatherData : ISubject
    {

        private double temperature;
        private double humidity;
        private double pressure;
        private readonly List<IObserver> observerslist;

        public WeatherData()
        {
            observerslist = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach(var observer in observerslist)
            {
                observer.Update(temperature,humidity,pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observerslist.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int i = observerslist.IndexOf(observer);
            if (i >= 0)
            {
                observerslist.Remove(observer);
            }
           
        }
        public void MeasurementsChanged()
        {
            NotifyObserver();
        }
        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
        

       
    }
}
