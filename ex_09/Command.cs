namespace ex_09
{
    abstract class Command
    {
        protected ArithmeticUnit unit;
        protected double operand;

        public abstract void Execute();

        public abstract void UnExecute();
    }
}