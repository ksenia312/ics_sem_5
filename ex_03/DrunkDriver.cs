namespace ex_03
{
    class DrunkDriverService : TransportService
    {
        public double Car { get; set; }
        public DrunkDriverService(string name, int carCategory) :
            base(name)
        {
            Car = carCategory;
        }
        public override double CostTransportation(double distance)
        {
            return distance * (6 - Car);
        }
        public override string ToString()
        {
            string s = String.Format("Company {0}, car's category {1}", Name, Car);
            return s;
        }
    }
    class DrunkDriverCompany : TransportCompany
    {
        public DrunkDriverCompany(string name)
            : base(name)
        { }
        public override TransportService Create(string n, int car)
        {
            return new DrunkDriverService(Name, car);
        }
    }
}
