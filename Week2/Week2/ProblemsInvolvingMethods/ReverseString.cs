using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.ProblemsInvolvingMethods {
    class ReverseString {
        public static void ReverseList(ref List<int> list) {
            List<int> temp = new List<int>();

            for (int index = list.Count - 1; index >= 0; index--) {
                temp.Add(list[index]);
            }
            list = temp;

            for (int i = 0; i < list.Count; i++) {
                Console.Write(list[i] + " ");
            }
        }
    }
}
