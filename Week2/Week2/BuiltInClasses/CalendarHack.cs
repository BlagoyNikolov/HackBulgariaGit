using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BuiltInClasses {
    class CalendarHack {
        public static void PrintCalendar(int month, int year, CultureInfo culture) {
            DateTime date = new DateTime(year, month, 1);
            string monthName = date.ToString("MMMM", culture);
            Console.WriteLine(monthName);

            for (int i = 0; i < 7; i++) {
                Console.Write(date.ToString("dddd", culture).PadLeft(12));
                date = date.AddDays(1);
            }
            Console.WriteLine();

            int[,] days = new int[5, 7];
            StringBuilder sb = new StringBuilder();
            int day = 1;
            int daysInMonth = System.DateTime.DaysInMonth(year, month);

            for (int i = 0; i < 5; ++i) {
                for (int j = 0; j < 7; ++j) {
                    days[i, j] = day;
                    if (day <= daysInMonth) {
                        sb.AppendFormat(("{0}"), days[i, j].ToString().PadLeft(12));
                        Console.Write(("{0}"), days[i, j].ToString().PadLeft(12));
                        day++;
                    }
                    else
                        sb.AppendFormat("");
                }
                sb.Append(Environment.NewLine);
                Console.WriteLine();
            }
        }
    }
}