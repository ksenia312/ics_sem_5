namespace ex_03
{
    class TaxiService : TransportService
    {
        public int Category { get; set; }
        public TaxiService(string name, int cat) :
            base(name)
        {
            Category = cat;
        }
        public override double CostTransportation(double distance)
        {
            return distance * Category;
        }
        public override string ToString()
        {
            string s = String.Format("Company {0}, ship's category {1}", Name, Category);
            return s;
        }
    }
    class TaxiCompany : TransportCompany
    {
        public TaxiCompany(string name)
        : base(name)
        { }
        public override TransportService Create(string n, int c)
        {
            return new TaxiService(Name, c);
        }
    }

}
