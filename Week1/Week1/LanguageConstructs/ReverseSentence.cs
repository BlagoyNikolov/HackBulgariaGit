using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.LanguageConstructs {
    class ReverseSentence {
       public static string ReverseEveryWord(string sentence) {
            string output = "";
            foreach (string word in sentence.Split(' ')) {
                string temp = "";
                foreach(char ch in word.ToCharArray()) { 
                    temp = ch + temp;
                }
                output = output + temp + " ";
            }
            return output;
        }
    }
}
