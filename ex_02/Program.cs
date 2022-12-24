// Abstract Factory

namespace ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory ford_car = new FordFactory();
            Client ford_client = new Client(ford_car);
            Console.WriteLine("MaxSpeed {0} is {1} km per hour", ford_client.ToString(), ford_client.RunMaxSpeed());

            CarFactory audi_car = new AudiFactory();
            Client audi_client = new Client(audi_car);
            Console.WriteLine("MaxSpeed {0} is {1} km per hour", audi_client.ToString(), audi_client.RunMaxSpeed());

        }
    }
}

/*
MaxSpeed Auto Ford is 220 km per hour
MaxSpeed Auto Audi is 200 km per hour
*/