using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class PrimeNumbers {
        public static bool IsPrime(int n) {
            for (int i = 2; i < n; i++) {
                if (n % i == 0 && i != n)
                    return false;
            }
            return true;
        }

        public static void ListFirstPrimes(int n) {
            int[] array = new int[n];
            int x = 0;
            for (int i = 1; i < n * 10; i++) {
                if (IsPrime(i) && x < n) {
                    array[x] = i;
                    x++;
                }

            }
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }
        }
    }
}
