using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.LanguageConstructs {
    public class NumberToListAndListToNumber {
        public static List<int> NumberToList(int n) {
            List<int> digits = new List<int>();

            while (n > 0) {
                digits.Add(n % 10);
                n /= 10;
            }
            digits.Reverse();

            foreach (int item in digits) {
                Console.WriteLine(item);
            }
            return digits;

        }

        public static int ListToNumber(List<int> digits) {
            int temp = 0;
            foreach (var item in digits) {
                temp = 10 * temp + item;
            }
            return temp;
        }
    }
}
