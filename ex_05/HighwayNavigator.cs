

namespace ex_05
{
    class HighwayNavigator : Navigator
    {
        public HighwayNavigator()
        {
            Title = "Highway Navigator";
        }
        public override string ToString()
        {
            return Title;
        }
        public override void CreateRoute(double[] start, double[] end, decimal[,] route)
        {

            for (int i = 0; i < 10; i++)
            {
                route[i, 0] = decimal.Round((decimal)(new Random().NextDouble() * 100));
                route[i, 1] = decimal.Round(route[i, 0] * 2);
            }
        }
    }
}
