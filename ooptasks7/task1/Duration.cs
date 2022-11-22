using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public void Print()
        {
            Console.WriteLine($"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}");
            Console.WriteLine("-------------");
        }
        public Duration()
        {
            Hours= 0;
            Minutes= 0;
            Seconds= 0;
        }
        public Duration(int h, int m, int s)
        {
            Hours= h;
            Minutes= m;
            Seconds= s;
        }
        public Duration(int s)
        {
            if (s >= 3600)
            {
                Hours= s/3600;
                s %= 3600;
            }
            if (s >= 60)
            {
                Minutes = s / 60;
                s %= 60;
            }
            if (s >= 0)
            {
                Seconds = s;
            }
        }
        public static Duration operator +(Duration d1, Duration d2)
        {
            Duration result = new Duration();
            result.Hours = d1.Hours+d2.Hours;
            result.Minutes = d1.Minutes+d2.Minutes;
            result.Seconds= d1.Seconds+d2.Seconds;
            return result;
        }
        public static Duration operator +(Duration d1, int s)
        {
            Duration d2 = new Duration(s);
            return d1+d2;
        }
        public static bool operator > (Duration d1, Duration d2)
        {
            int s1= d1.Seconds+(d1.Minutes*60)+(d1.Hours * 3600);
            int s2 = d2.Seconds+(d2.Minutes * 60)+(d2.Hours * 3600);
            if(s1 > s2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator < (Duration d1, Duration d2)
        {
            int s1 = d1.Seconds + (d1.Minutes * 60) + (d1.Hours * 3600);
            int s2 = d2.Seconds + (d2.Minutes * 60) + (d2.Hours * 3600);
            if (s1 < s2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator >= (Duration d1, Duration d2)
        {
            return !(d1 < d2);

        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return !(d1 > d2);

        }


    }
}
