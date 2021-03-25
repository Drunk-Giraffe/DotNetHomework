using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _4._2
{
    class clock
    {
        static int passTime = 0;
        public delegate void ActionHandler(object sender);
        public event ActionHandler Tick;
        public event ActionHandler Alarm;
        private bool clockOn = false;
        public int hour { get;set; }
        public int minute { get; set; }
        public int second { get; set; }
        public void TimeGoesBy()
        {
            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
            }
            if (minute == 60)
            {
                minute = 0;
                hour++;
            }
            if (hour == 24)
            {
                hour = 0;
            }
        }
        public void ClockOn()
        {
            clockOn = true;
            hour= DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            while (clockOn)
            {
                Tick(this);
                passTime++;
                if (passTime == 10)
                {
                    Alarm(this);
                    passTime = 0;
                }
                Thread.Sleep(1000);
                TimeGoesBy();
            }
        }
    }
}
