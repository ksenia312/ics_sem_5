using System;

namespace ex_07
{
    internal class Microwave
    {
        private Drive drive;
        private Power power;
      
        private Notification notification; 

        public Microwave(Drive drive, Power power, Notification notification)
        {
            this.drive = drive;
            this.power = power;
            this.notification = notification;
        }

        public void Cook() // added method Cook
        {
            notification.StartNotification();
            power.MicrowavePower = 1200;
            drive.TurlLeft();
            drive.TurlLeft();
            drive.TurlLeft();
            drive.Stop();
            drive.TurlLeft();
            drive.TurlLeft();
            drive.TurlLeft();
            drive.Stop();
            drive.TurlRight();
            drive.TurlRight();
            drive.TurlRight();
            drive.Stop();
            drive.TurlRight();
            drive.TurlRight();
            drive.TurlRight();
            drive.Stop();
            power.MicrowavePower = 0;
            notification.StopNotification();
        }

        public void Defrost()
        {
            notification.StartNotification();
            power.MicrowavePower = 1000;
            drive.TurlRight();
            drive.TurlRight();
            power.MicrowavePower = 500;
            drive.Stop();
            drive.TurlLeft();
            drive.TurlLeft();
            power.MicrowavePower = 200;
            drive.Stop();
            drive.TurlRight();
            drive.TurlRight();
            drive.Stop();
            power.MicrowavePower = 0;
            notification.StopNotification();
        }
    }
}