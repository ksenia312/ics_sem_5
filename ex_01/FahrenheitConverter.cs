namespace ex_01
{
    // FahrenheitConverter as Adapter from Fahrenheit (working with FahrenheitSensor)
    class FahrenheitConverter { 
        public FahrenheitConverter(FahrenheitSensor fahrenheitSensor)
        {
            this.fahrenheitSensor = fahrenheitSensor;
        }
        public decimal toCelsius()
        {
            return decimal.Round((fahrenheitSensor.getTemperature() - 32) * 5 / 9);
        }
        private FahrenheitSensor fahrenheitSensor;
    };

}
