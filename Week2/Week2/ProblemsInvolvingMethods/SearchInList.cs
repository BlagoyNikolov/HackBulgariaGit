using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.ProblemsInvolvingMethods {
    class SearchInList {
        public static bool TryFindSubstring(List<string> list, string searched, out int foundIndex) {
            bool hasString = false;
            foundIndex = 0;
            for (int i = 0; i < list.Count; i++) {
                if (list[i].Contains(searched)) {
                    foundIndex = i;
                    hasString = true;
                    break;
                }
            }
            Console.WriteLine(hasString + ", index: " + foundIndex);
            return hasString;
        }
    }
}
