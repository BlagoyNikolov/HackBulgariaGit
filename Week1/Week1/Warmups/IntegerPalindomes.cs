using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class IntegerPalindomes {
       public static bool IsIntPalindrome(int n) {
            string str = n.ToString();
            int i = 0;
            int j = str.Length - 1;

            while (i < j) {
                if (str[i] != str[j])
                    return false;
                i++;
                j--;
            }
            return true;

        }

        public static int GetLargestPalindrome(int N) {
            int temp = 0;
            for (int i = N; i > 0; i--) {
                if (IsIntPalindrome(i)) {
                    temp = i;
                    break;
                }
            }
            return temp;
        }
    }
}
