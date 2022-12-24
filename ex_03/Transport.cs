namespace ex_03
{
    abstract class TransportService
    {
        public string Name { get; set; }
        public TransportService(string name)
        {
            Name = name;
        }
        abstract public double CostTransportation(double distance);
    }

    abstract class TransportCompany
    {
        public string Name { get; set; }
        public TransportCompany(string n)
        {
            Name = n;
        }
        public override string ToString()
        {
            return Name;
        }
        abstract public TransportService Create(string n, int k);
    }
}
