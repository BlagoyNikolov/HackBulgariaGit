using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class HackNumbers {
        public static bool isHack(int n) {
            string binary = Convert.ToString(n, 2);
            if ((CheckPalindrome(binary) && CheckOddNumber(binary))) {
                return true;
            }
            else {
                return false;
            }

        }

        public static bool CheckPalindrome(string str) {
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

        public static bool CheckOddNumber(string str) {
            int counter = 0;
            for (int i = 0; i <= str.Length - 1; i++) {
                if (str[i] == '1') {
                    counter++;
                }
            }
            if (counter % 2 == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public static int nextHack(int n) {
            int next = n + 1;
            while (isHack(next) == false) {
                next++;
            }
            return next;
        }
    }
}
