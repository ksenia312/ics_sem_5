// Strategy
namespace ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] start = { 1, 2 };
            double[] end = { 4, 5 };
            decimal[,] route = new decimal[13, 23];

            Navigator highwayNavigator = new HighwayNavigator();
            Context highwayContext = new Context(highwayNavigator, start, end, route);
            highwayContext.CreateRoute();
            highwayContext.Print();


            Navigator ordinaryRoadNavigator = new OrdinaryRoadNavigator();
            Context ordinaryRoadContext = new Context(ordinaryRoadNavigator, start, end, route);
            ordinaryRoadContext.CreateRoute();
            ordinaryRoadContext.Print();
        }
    }
}

/*
Highway Navigator
(79, 158)(26, 52)(69, 138)(50, 100)(99, 198)(60, 120)(91, 182)(87, 174)(12, 24)(79, 158)
Ordinary Road Navigator
(82, 27)(60, 20)(2, 1)(50, 17)(4, 1)(69, 23)(55, 18)(24, 8)(22, 7)(42, 14)
 */