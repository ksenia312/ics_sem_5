// Patten Command
// Turns queries into objects, allowing them to be passed as arguments when methods are called

namespace ex_09
{
    internal class Program
    {
        static void Main()
        {
            var calculator = new Calculator();
            double result = 0;
            result = calculator.Add(5);
            Console.WriteLine(result);

            result = calculator.Add(4);
            Console.WriteLine(result);

            result = calculator.Add(3);
            Console.WriteLine(result);

            result = calculator.Redo();
            Console.WriteLine(result);

            result = calculator.Undo();
            Console.WriteLine(result);

            result = calculator.Multiply(64);
            Console.WriteLine(result);

            result = calculator.Undo(); 
            Console.WriteLine(result); 

            result = calculator.Divide(2); 
            Console.WriteLine(result); 
        }
    }
}

/*
5
9
12
15
12
768
12
6
*/