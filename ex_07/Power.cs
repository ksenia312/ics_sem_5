using System;


namespace ex_07
{
    internal class Power
    {
        public event EventHandler powerevent;
        private int _power;


        public int MicrowavePower
        {
            get { return _power; }
            set
            {
                _power = value;
                if (powerevent != null)
                    powerevent(this, new EventArgs());
            }
        }

        public override string ToString()
        {
            return String.Format("Got power {0}w ", MicrowavePower);
        }
    }
}