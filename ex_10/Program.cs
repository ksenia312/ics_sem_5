// Pattern Decorator
// Allows to dynamically connect additional functionality to the object

namespace ex_10
{
    internal class Program
    {
        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }
        static void Main(string[] args)
        {

            Renault reno = new Renault("Рено", "Renault LOGAN Active", 10000.0);
            Print(reno);

            Tesla tesla = new Tesla("Tesla", "Tesla Model 3", 51000.0); 
            Print(tesla);

            AutoBase navigation_tesla = new MediaNAV(tesla, "Navigation"); 
            Print(navigation_tesla);

            AutoBase navigation_security_tesla = new SystemSecurity(navigation_tesla, "Security");
            Print(navigation_security_tesla);
        }
    }
}