// Factory Method

namespace ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransportCompany taxiCompany = new TaxiCompany("Taxi Service");
            TransportService taxiService = taxiCompany.Create("Taxi", 1);
            double distance = 206;
            Print(taxiService, distance);

            TransportCompany shipCompany = new ShipCompany("Ship Service");
            TransportService shipService = shipCompany.Create("Ship", 2);
            distance = 655;
            Print(shipService, distance);


            TransportCompany drunkDriverCompany = new DrunkDriverCompany("Drunk Driver Service");
            TransportService drunkDriverService = drunkDriverCompany.Create("Drunk Driver", 3);
            distance = 324;
            Print(taxiService, distance);

        }
        private static void Print(TransportService transportService, double distance)
        {
            Console.WriteLine("Company {0}, distance {1}, cost: {2}",
                transportService.ToString(), distance, transportService.CostTransportation(distance));
        }
    }
}

/*
Company Company Taxi Service, ship's category 1, distance 206, cost: 206
Company Company Ship Service, delivery 2, distance 655, cost: 1310
Company Company Taxi Service, ship's category 1, distance 324, cost: 324
*/