using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class PalindromeScore {
        public static int pl = 1;
        public static int PScore(int n) {
            int pol = 1;
            string str = n.ToString();
            for (int i = 0; i < str.Length / 2; i++) {
                if (!str[i].Equals(str[str.Length - 1 - i])) {
                    pol = 0;
                    break;
                }
            }
            if (pol == 1)
                return pl;
            else {
                pl++;
                PalindromeScore.PScore2(n);
            }
            return pl;
        }
        
        public static void PScore2(int n) {
            string str2 = n.ToString();
            string reversen = new string(str2.Reverse().ToArray());
            int reversex = int.Parse(reversen);
            int x = int.Parse(str2);
            int sum = x + reversex;
            string strsum = sum.ToString();
            int result = Int32.Parse(strsum);
            PalindromeScore.PScore(result);
        }
    }
}