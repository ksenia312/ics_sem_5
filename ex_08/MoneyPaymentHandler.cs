namespace ex_08
{

    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("Making transfers through money transfer systems");
            else if (Successor != null)

                Successor.Handle(receiver);
        }
    }
}