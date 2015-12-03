using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class CharHistogramA {
        public static void CharHistogram(String str) {
            int countCharacters = 1;
            for (int i = 0; i < str.Length - 1; i++) {
                if (str[i] != str[i + 1]) {
                    countCharacters++;
                }
            }
            char[] charArray = new char[countCharacters];
            int[] charNumberArray = new int[countCharacters];

            int temp = 0;
            int countOccurencesInStr = 1;
            charArray[charArray.Length - 1] = str[str.Length - 1];
            for (int i = 0; i < str.Length - 1; i++) {
                if (str[i] != str[i + 1]) {
                    charArray[temp] = str[i];
                    charNumberArray[temp] = countOccurencesInStr;
                    countOccurencesInStr = 1;
                    temp++;
                }
                else {
                    countOccurencesInStr++;
                }
            }

            charNumberArray[charNumberArray.Length - 1] = countOccurencesInStr;
            Console.Write("{");
            for (int i = 0; i < charArray.Length; i++) {
                Console.Write("'" + charArray[i] + "'" + " : " + charNumberArray[i] + " ");
            }
            Console.Write("}");
        }
    }
}
