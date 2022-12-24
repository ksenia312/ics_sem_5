// Singleton

namespace ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory fordCar = new FordFactory();
            Client fordClient = new Client(fordCar);
            Console.WriteLine("MaxSpeed {0} is {1} km per hour", fordClient.ToString(), fordClient.RunMaxSpeed());

            fordCar.CreateCar("New Ford");
            Client newFordClient = new Client(fordCar);
            Console.WriteLine("MaxSpeed {0} is {1} km per hour", newFordClient.ToString(), newFordClient.RunMaxSpeed());
        }
    }
}

/*
MaxSpeed Auto Ford is 53 km per hour
MaxSpeed Auto Ford is 53 km per hour
*/