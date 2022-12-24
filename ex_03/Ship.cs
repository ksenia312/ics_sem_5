namespace ex_03
{
    class ShipService : TransportService
    {
        public double Tariff { get; set; }
        public ShipService(string name, int taff) :
        base(name)
        {
            Tariff = taff;
        }
        public override double CostTransportation(double distance)
        {
            return distance * Tariff;
        }
        public override string ToString()
        {
            string s = String.Format("Company {0}, delivery {1}", Name, Tariff);
            return s;
        }
    }
    class ShipCompany : TransportCompany
    {
        public ShipCompany(string name)
        : base(name)
        { }
        public override TransportService Create(string n, int t)
        {
            return new ShipService(Name, t);
        }
    }
}
