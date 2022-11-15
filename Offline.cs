using System;

namespace Passtask3{
    public class Offline:Transaction{
        private int _bonusPoints;
        private Boolean _state;

        public Offline(int amounts, string date, bool state):base(amounts, date){
            _state = state;
            _bonusPoints = 5;
        }

        public override int UpdatePoints()
        {
           return (Amounts/10) + _bonusPoints;
        }

        public Boolean State{
            get{return _state; }
            set{_state = value; }
        }

        public override string StringMessage()
        {
            if(_state == true){
            return "Payment Mode = Offline";
            }
            else{
                return "Payment Mode = Offline" + "\nAccount Information Locked";
            }
        } 
    }
}