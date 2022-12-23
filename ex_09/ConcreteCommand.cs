namespace ex_09
{
    internal class ConcreteCommand
    {
        internal class Add : Command
        {
            public Add(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            public override void Execute()
            {
                unit.Run('+', operand);
            }

            public override void UnExecute()

            {
                unit.Run('-', operand);
            }
        }

        internal class Subtract : Command
        {

            public Subtract(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            public override void Execute()
            {
                unit.Run('-', operand);
            }

            public override void UnExecute()

            {
                unit.Run('+', operand);
            }
        }

        internal class Multiply : Command
        {
            public Multiply(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            public override void Execute()
            {
                unit.Run('*', operand);
            }

            public override void UnExecute()
            {
                unit.Run('/', operand);
            }
        }

        internal class Divide : Command
        {
            public Divide(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            public override void Execute()
            {
                unit.Run('/', operand);
            }

            public override void UnExecute()
            {
                unit.Run('*', operand);
            }
        }
    }
}
