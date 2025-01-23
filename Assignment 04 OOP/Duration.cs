using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP
{
    public abstract class Duration
    {
        public abstract int Hours { get; set; }
        public abstract int Minutes { get; set; }
        public abstract int Seconds { get; set; }

        public abstract void TheTime();

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

        
        public class Time : Duration
        {
            public override int Hours { get; set; }
            public override int Minutes { get; set; }
            public override int Seconds { get; set; }
            
            public Time(int hours, int minutes, int seconds) 
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }

            public Time(int Seconds)
            {
                Hours = Seconds / 3600;
                Minutes = (Seconds % 3600) / 60;
                Seconds = Seconds % 60;
            }
            public override void TheTime()
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }
    }
}
