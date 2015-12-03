using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.LanguageConstructs {
    class AnagramSubsequence {
        public static bool HasAnagramOf(string A, string B) {
            int temp = 0;
            bool hasAnagram = true;
            if (A.Length <= B.Length) {
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
                hasAnagram = false;
            if (temp < A.Length)
                hasAnagram = false;
            return hasAnagram;
        }
    }
}
