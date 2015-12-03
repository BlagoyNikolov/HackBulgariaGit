using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Fibonacci {
        public static void fibNumber(int n) {
            int temp = 0;
            int first = 1;
            int second = 1;
            Console.Write(first + "" + second);
            for (int i = 2; i < n; i++) {
                temp = first + second;
                first = second;
                second = temp;
                Console.Write(temp);
            }
        }
    }
}
