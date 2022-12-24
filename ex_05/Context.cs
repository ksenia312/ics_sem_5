

namespace ex_05
{
    class Context
    {
        Navigator navigator;
        double[] start;
        double[] end;
        decimal[,] route;
        public Context(Navigator strategy, double[] start, double[] end, decimal[,] route)
        {
            this.navigator = strategy;
            this.start = start;
            this.end = end;
            this.route = route;
        }
        public void CreateRoute()
        {
            navigator.CreateRoute(start, end, route);

        }
        public void Print()
        {
            Console.WriteLine(navigator.ToString());
            for (int i = 0; i < 10; i++) Console.Write($"({route[i, 0]}, {route[i, 1]})");
            Console.WriteLine();
        }
    }

}
