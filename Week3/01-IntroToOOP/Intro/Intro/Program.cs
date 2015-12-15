using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro {
    class Program {
        static void Main(string[] args) {
            //Time
            Time test = new Time(20, 34, 21, 1, 12, 2015);
            test.ToString();
            Time.Now();

            //Pair
            Time time1 = new Time(20, 34, 21, 1, 12, 2015);
            Time time2 = new Time(20, 34, 21, 1, 12, 2015);
            Pair pair1 = new Pair(time1, time2);

            Time time3 = new Time(20, 34, 21, 1, 12, 2015);
            Time time4 = new Time(20, 34, 21, 1, 12, 2015);
            Pair pair2 = new Pair(time3, time4);

            Console.WriteLine(pair1.ToString());
            Console.WriteLine(pair1.Equals(pair2));
            Console.WriteLine(pair1 == pair2);
            Console.WriteLine(pair1 != pair2);

            //Fractions
        }
    }
}
