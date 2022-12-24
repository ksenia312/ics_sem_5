namespace ex_04
{
    class FordFactory : CarFactory
    {
        public override AbstractCar CreateCar(string name)
        {
            return FordCar.getInstance(name);
        }
        public override AbstractEngine CreateEngine()
        {
            return FordEngine.getInstance();
        }
    }

    class FordCar : AbstractCar
    {
        private static FordCar instance;

        public string Name { get; private set; }

        protected FordCar(string name)
        {
            Name = name;
        }
        public static FordCar getInstance(string name)
        {
            if (instance == null) instance = new FordCar(name);
            return instance;
        }

        public override decimal MaxSpeed(AbstractEngine engine)
        {
            decimal ms = engine.MaxSpeed;
            return ms;
        }

        public override string ToString()
        {
            return "Auto " + Name;
        }
    }

    class FordEngine : AbstractEngine
    {
        private static FordEngine instance;
        protected FordEngine()
        {
            MaxSpeed = decimal.Floor((decimal)(new Random().NextDouble() * 100 + 50));
        }
        public static FordEngine getInstance()
        {
            if (instance == null) instance = new FordEngine();
            return instance;
        }


    }
}
