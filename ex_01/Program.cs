// Pattern Adapter 
// Converting from external source fahrenheit sensor to Celsius
namespace ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FahrenheitSensor fahrenheitSensor = new FahrenheitSensor();
            FahrenheitConverter fahrenheitConverter = new FahrenheitConverter(fahrenheitSensor);

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine($"Got Fahrenheit: {fahrenheitSensor.getTemperature()}");
                Console.WriteLine($"Converted to Celsius: {fahrenheitConverter.toCelsius()}");
                Console.WriteLine(" --- ");
            }
        }
    }
}

/*
Got Fahrenheit: 130
Converted to Celsius: 38
 ---
Got Fahrenheit: 52
Converted to Celsius: 27
 ---
Got Fahrenheit: 120
Converted to Celsius: 25
 ---
Got Fahrenheit: 44
Converted to Celsius: 20
 ---
Got Fahrenheit: 75
Converted to Celsius: 52
 ---
*/
