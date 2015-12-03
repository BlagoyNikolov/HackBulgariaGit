using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BuiltInClasses {
    class DateSums {
        public static void PrintDatesWithGivenSum(int year, int sum) {
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);
            int x = 0;
            int y = year % 10 + (year / 10) % 10 + (year / 100) % 10 + year / 1000;
            x = y;

            for (DateTime current = startDate; current <= endDate; current = current.AddDays(1)) {
                x += current.Day % 10 + current.Day / 10;
                x += current.Month % 10 + current.Month / 10;
                if (x == sum) {
                    Console.WriteLine("{0: dd MM yyyy}", current);
                }
                x = y;
            }
        }
    }
}