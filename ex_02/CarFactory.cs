namespace ex_02
{
    abstract class CarFactory
    {
        public abstract AbstractCar CreateCar();
        public abstract AbstractEngine CreateEngine();
    }
    abstract class AbstractCar
    {
        public string Name { get; set; }
        public string BodyType { get; set; }
        public abstract int MaxSpeed(AbstractEngine engine);
    }
    abstract class AbstractEngine
    {
        public int MaxSpeed { get; set; }
    }
}
