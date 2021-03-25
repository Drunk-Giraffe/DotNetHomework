using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            clock Clock = new clock();
            Clock.Tick += s => Console.WriteLine("Tick,Tock");
            Clock.Alarm+= s => Console.WriteLine("Ringing!当前时间为"+Clock.hour.ToString()+"时" + Clock.minute.ToString() + "分" + Clock.second.ToString() + "秒");
            Clock.ClockOn();
        }
    }
}
