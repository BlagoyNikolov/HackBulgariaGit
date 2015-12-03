using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Consonants {
        public static int CountConsonants(String str) {
            int counter = 0;
            String Consonants = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";
            for (int i = 0; i < str.Length; i++) {
                for (int j = 0; j < Consonants.Length; j++) {
                    if (str[i] == Consonants[j]) {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
