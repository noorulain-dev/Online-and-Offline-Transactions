using System;

namespace Passtask3{

    public class Online:Transaction{
        
        private PaymentMode _mode;
        public enum PaymentMode{
            CreditCard,
            Paypal
        }

        public Online(int amounts, PaymentMode mode, string date):base(amounts, date){
            _mode = mode;
        }

        public PaymentMode Mode{
            get{return _mode;}
            set{_mode = value;}
        }

        public override int UpdatePoints()
        {
           return (Amounts/10);
        }

        public override string StringMessage()
        {
            if(_mode == PaymentMode.CreditCard){
                return "Payment type : Credit Card" + "\nPayment mode : Online";
            }

            else{
                return "Payment type : Paypal" + "\nPayment mode : Online";
            }
        }
    }
}