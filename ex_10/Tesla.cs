namespace ex_10
{
    internal class Tesla : AutoBase
    {
        public Tesla(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }

        public override double GetCost()
        {
            return CostBase * 1.3;
        }
    }
}
