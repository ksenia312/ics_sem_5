namespace ex_04
{
    abstract class CarFactory
    {
        public abstract AbstractCar CreateCar(string name = "Ford");
        public abstract AbstractEngine CreateEngine();
    }

    abstract class AbstractCar
    {
        public string Name { get; set; }
        public abstract decimal MaxSpeed(AbstractEngine engine);
    }

    abstract class AbstractEngine
    {
        public decimal MaxSpeed { get; set; }
    }

}
