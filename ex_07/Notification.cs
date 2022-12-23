using System;


namespace ex_07
{
    internal class Notification
    {
        public event EventHandler notificationevent; 
        private string mess;

        public string MessageFin
        {
            get { return mess; }
            set
            {
                mess = value;
                if (notificationevent != null)
                    notificationevent(this, new EventArgs());
            }
        }

        public void StartNotification()

        {
            MessageFin = "Start operation";
        }

        public void StopNotification()
        {
            MessageFin = "Stop operation";
        }

        public override string ToString()
        {
            return String.Format("Message: {0}", MessageFin);
        }
    }
}

/*
Defrost
Message: Start operation
Got power 1000w
Twist: Turn Right
Twist: Turn Right
Got power 500w
Twist: Stop
Twist: Turn Left
Twist: Turn Left
Got power 200w
Twist: Stop
Twist: Turn Right
Twist: Turn Right
Twist: Stop
Got power 0w
Message: Stop operation

Cook
Squeek: Pii!
Message: Start operation
Got power 900w
Twist: Turn Left
Twist: Turn Left
Twist: Stop
Twist: Turn Right
Twist: Turn Right
Twist: Stop
Twist: Turn Left
Twist: Turn Left
Twist: Stop
Twist: Turn Right
Twist: Turn Right
Twist: Stop
Got power 0w
Message: Stop operation
Squeek: Piiiiiii!
*/