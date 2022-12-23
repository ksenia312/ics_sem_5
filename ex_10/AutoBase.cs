namespace ex_10
{
    abstract class AutoBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double CostBase { get; set; }

        public abstract double GetCost();

        public override string ToString()
        {
            return String.Format("Your auto: \n{0} \nDescription: {1} \nCost {2}\n", Name, Description, GetCost());
        }
    }
}
