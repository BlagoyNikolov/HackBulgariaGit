using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.LanguageConstructs {
    class CopyCharacterKTtimes {
        public static string CopyEveryChar(string input, int k) {
            List<char> output = new List<char>();
            for (int i = 0; i < input.Length; i++) {
                for (int j = 0; j < k; j++) {
                    output.Add(input[i]);
                }
            }
            foreach (var item in output) {
                Console.Write(item);
            }
            Console.WriteLine();
            return output.ToString();

            //char[] output1 = new char[(input.Length) * k];
            //char[] ch = input.ToCharArray();

            //for (int i = 0; i < input.Length; i++) {
            //    for (int j = 0; j < k; j++) {
            //        output1[i] = ch[i];
            //    }
            //}
            //return output1.ToString();
        }
    }
}
