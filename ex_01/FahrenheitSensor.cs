using System;

namespace ex_01
{
    class FahrenheitSensor
    {
       
        public decimal getTemperature()
        {
            double v = (new Random().NextDouble() * 100 + 32);
            return decimal.Round((decimal)v);
        }
    }
}
