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

            
        }
    }
}
