using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication2.Warmups {
    class SumNumbersInString {
        public static int SumOfNumbersInString(String input) {
            int sum = 0;
            string[] numbers = Regex.Split(input, @"\D+");
            foreach (string value in numbers) {
                if (!string.IsNullOrEmpty(value)) {
                    int i = int.Parse(value);
                    Console.WriteLine("Numbers: {0}", i);
                    sum += i;
                }
            }
            Console.WriteLine("The sum is: {0}", sum);

            return sum;
        }
    }
}
