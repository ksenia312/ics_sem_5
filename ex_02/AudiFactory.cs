

namespace ex_02
{
    class AudiFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new AudiCar("Audi", "cs 4");
        }
        public override AbstractEngine CreateEngine()
        {
            return new AudiEngine();
        }
    }

    class AudiCar : AbstractCar
    {
        public AudiCar(string name, string bt)
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

    class AudiEngine : AbstractEngine
    {
        public AudiEngine()
        {
            MaxSpeed = 200;
        }
    }
}
