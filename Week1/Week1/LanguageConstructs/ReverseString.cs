using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.LanguageConstructs {
    class ReverseString {
        public static string ReverseMe(string original) {
            string output = "";
            for (int i = original.Length- 1; i >=0 ; i--) {
                output += original[i];
            }
            return output;
        }
    }
}
