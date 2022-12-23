// Chain of resposibilities
// Create an ability to process a request to multiple objects

namespace ex_08
{
    internal class Program
    {
        static void Main()
        {
            Receiver receiver = new Receiver(false, true, true);
            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
            bankPaymentHandler.Successor = moneyPaymentHnadler;
            moneyPaymentHnadler.Successor = paypalPaymentHandler;
            bankPaymentHandler.Handle(receiver);
            paypalPaymentHandler.Handle(receiver);

            Console.WriteLine("--------------------------------------------");

            receiver = new Receiver(true, true, false);
            bankPaymentHandler = new BankPaymentHandler();
            moneyPaymentHnadler = new MoneyPaymentHandler();
            paypalPaymentHandler.Successor = moneyPaymentHnadler;
            moneyPaymentHnadler.Successor = bankPaymentHandler;
            paypalPaymentHandler.Handle(receiver);
        }
    }
}