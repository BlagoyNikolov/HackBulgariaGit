using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.LanguageConstructs {
    class IncreasingAndDecreasingSequences {
        public static bool IsIncreasing(int[] sequence) {
            bool flag = true;
            for (int i = 0; i < sequence.Length-1; i++) {
                if (sequence[i] >= sequence[i + 1]) {
                    flag =false;
                }
            }
            return flag;
        }

        public static bool IsDecreasing(int[] sequence) {
            bool flag = true;
            for (int i = 0; i < sequence.Length - 1; i++) {
                if (sequence[i] <= sequence[i + 1]) {
                    flag = false;
                }
            }
            return flag;
        }
    }
}
