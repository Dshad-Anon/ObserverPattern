using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : IObserver, IDisplayElement
    {
        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Update(double temp, double humidity, double pressure)
        {
            throw new NotImplementedException();
        }
    }
}
