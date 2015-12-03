using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class WorkingWithDigits {
        public static void CountDigits(int n) {
            int counter = 0;
            for (int i = 0; n > 0; i++) {
                n = n / 10;
                counter++;
                Console.WriteLine(n);
            }
            Console.WriteLine(counter);
        }

        public static void sumDigits(int n) {
            int sum = 0;
            while (n != 0) {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine(sum);
        }

        public static void factorialDigits(int n) {
            int number = 0;
            int sum = 0;
            while (n != 0) {
                number = n % 10;
                n /= 10;
                sum += Factorial.ClassicFactorial(number);
            }
        }
    }
}
