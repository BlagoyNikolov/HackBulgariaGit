using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BuiltInClasses {
    class Friday {
        public static int UnfortunateFridays(int startYear, int endYear) {
            int number = 0;

            DateTime startDate = new DateTime(startYear, 1, 1);
            DateTime endDate = new DateTime(endYear, 1, 1);

            for (DateTime i = startDate; i < endDate; i = i.AddDays(1)) {
                if(i.DayOfWeek == DayOfWeek.Friday && i.Day == 13) {
                    number++;
                }
            }
            return number;
        }
    }
}
