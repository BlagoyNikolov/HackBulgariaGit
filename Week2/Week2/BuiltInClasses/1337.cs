using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BuiltInClasses {
    class _1337 {
        public static void HackerTime() {
            DateTime endDate = new DateTime(DateTime.Now.Year,12,21,13,37,00);
            DateTime now = DateTime.Now;
            if (now > endDate) {
                endDate = endDate.AddYears(1);
            }
            TimeSpan ts = endDate - now;
            Console.WriteLine("Time to HackTime remaining: {0:dd\\dhh\\hmm\\m}", ts);
        }
    }
}
