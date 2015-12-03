using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.LanguageConstructs {
    class StringAnagrams {
        public static bool Anagram(string A, string B) {
            bool isAnagram = true;
            int temp = 0;
            if (A.Length == B.Length) {
                foreach (var item in A) {
                    for (int i = 0; i < B.Length; i++) {
                        if (item == B[i]) {
                            temp++;
                            break;
                        }
                    }
                }
            }
            else
                isAnagram = false;
            if (temp < A.Length)
                isAnagram = false;
            return isAnagram;
        }
    }
}
