namespace ex_02
{
    class FordFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new FordCar("Ford", "Hatchback");
        }
        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }
    }
    class FordCar : AbstractCar
    {
        public FordCar(string name, string bt)
        {
            Name = name;
            BodyType = bt;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.MaxSpeed;
            return ms;
        }
        public override string ToString()
        {
            return "Auto " + Name;
        }
    }
    class FordEngine : AbstractEngine
    {
        public FordEngine()
        {
            MaxSpeed = 220;
        }
    }
}
