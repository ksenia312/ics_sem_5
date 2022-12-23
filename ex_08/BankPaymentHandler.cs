namespace ex_08
{
    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Performing a bank transfer");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}