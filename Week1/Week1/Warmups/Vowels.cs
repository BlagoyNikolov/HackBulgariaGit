using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Vowels {
        public static int CountVowels(String str) {
            int counter = 0;
            String Vowels = "aeiouyAEIOUY";
            for (int i = 0; i < str.Length; i++) {
                for (int j = 0; j < Vowels.Length; j++) {
                    if (str[i] == Vowels[j]) {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
