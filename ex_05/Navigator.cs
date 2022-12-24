
namespace ex_05
{
    abstract class Navigator
    {
        public string Title { get; set; }
        public abstract void CreateRoute(double[] start, double[] end, decimal[,] route);
    }
}
