using System;


namespace ex_08
{
    abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; } 

        public abstract void Handle(Receiver receiver);
    }

}