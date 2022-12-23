
namespace ex_09
{
    internal class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;

        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }

        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }

        public double Undo()
        {
            controlUnit.Undo();
            return arithmeticUnit.Register;
        }


        public double Undo(int x)
        {
            controlUnit.Undo(x);
            return arithmeticUnit.Register;
        }

        public double Redo()
        {
            controlUnit.Redo();
            return arithmeticUnit.Register;
        }

        public double Redo(int x)
        {
            controlUnit.Redo(x);
            return arithmeticUnit.Register;
        }

        public double Add(double operand)
        {
            return Run(new ConcreteCommand.Add(arithmeticUnit, operand));
        }

        public double Subtract(double operand)
        {
            return Run(new ConcreteCommand.Subtract(arithmeticUnit, operand));
        }

        public double Multiply(double operand)
        {
            return Run(new ConcreteCommand.Multiply(arithmeticUnit, operand));
        }

        public double Divide(double operand)
        {
            return Run(new ConcreteCommand.Divide(arithmeticUnit, operand));
        }
    }
}