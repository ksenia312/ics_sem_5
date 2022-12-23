using System;


namespace ex_07
{
    internal class Drive
    {
        public event EventHandler driveevent;
        private string twist;
        public string Twist
        {
            get { return twist; }
            set
            {
                twist = value;
                if (driveevent != null)
                    driveevent(this, new EventArgs());
            }
        }
        public Drive()
        {
            Twist = "Исходная позиция";
        }

        public void TurlLeft()
        {
            Twist = "Turn Left";
        }

        public void TurlRight()
        {
            Twist = "Turn Right";
        }

        public void Stop()
        {
            Twist = "Stop";
        }

        public override string ToString()
        {
            return String.Format("Twist: {0}", Twist); ;
        }
    }
}