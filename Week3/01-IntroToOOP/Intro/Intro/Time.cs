using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro {
    class Time {
        public int hours;
        public int minutes;
        public int seconds;
        public int day;
        public int month;
        public int year;

        public Time(int hours, int minutes, int seconds, int day, int month, int year) {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString() {
            string result = string.Format("The time is: {0}:{1}:{2} | The date is: {3}.{4}.{5}", hours, minutes, seconds, day, month, year);
            Console.WriteLine(result);
            return result;
        }

        public static Time Now() {
            DateTime now = DateTime.Now;
            Time timeNow = new Time(now.Hour, now.Minute, now.Second, now.Day, now.Month, now.Year);
            timeNow.ToString();
            return timeNow;
        }
    }
}
