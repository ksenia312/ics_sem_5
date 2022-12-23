// Facade.
// This is a template for creating many logics from a pattern.
// Microwave gets other classes and makes an algthorithm using them
// A new method is Cook.

namespace ex_07
{
    internal class Program
    {
        static void notification_notificationevent(object sender, EventArgs e)
        {
            Notification n = (Notification)sender;
            Console.WriteLine(n.ToString());
        }

        static void drive_driveevent(object sender, EventArgs e)
        {
            Drive d = (Drive)sender;
            Console.WriteLine(d.ToString());
        }

        private static void power_powerevent(object sender, EventArgs e)
        {
            Power p = (Power)sender;
            Console.WriteLine(p.ToString());
        }


        static void Main()
        {
            var drive = new Drive();
            var power = new Power();

            var notification = new Notification();

            var microwave = new Microwave(drive, power, notification);

            power.powerevent += power_powerevent;
            drive.driveevent += drive_driveevent;
            notification.notificationevent += notification_notificationevent;

            Console.WriteLine("Defrost");
            microwave.Defrost();

            Console.WriteLine();
            Console.WriteLine("Cook");
            microwave.Cook();
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
Message: Start operation
Got power 1200w
Twist: Turn Left
Twist: Turn Left
Twist: Turn Left
Twist: Stop
Twist: Turn Left
Twist: Turn Left
Twist: Turn Left
Twist: Stop
Twist: Turn Right
Twist: Turn Right
Twist: Turn Right
Twist: Stop
Twist: Turn Right
Twist: Turn Right
Twist: Turn Right
Twist: Stop
Got power 0w
Message: Stop operation
*/