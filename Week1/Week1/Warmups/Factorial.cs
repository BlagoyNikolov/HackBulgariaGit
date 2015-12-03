using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Factorial {
        public static int ClassicFactorial(int n) {
            int x = 1;
            for (int i = 1; i <= n; i++) {
                x = x * i;
            }
            Console.WriteLine(x);
            return x;
        }

        public static int RecursiveFactorial(int n) {
            int x = 1;
            if (n <= 1) {
                return 1;
            }
            else {
                x = n * RecursiveFactorial(n - 1);
                Console.WriteLine(x);
                return x;
            }
        }
    }
}
