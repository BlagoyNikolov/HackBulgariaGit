using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.ProblemsInvolvingMethods {
    class JoiningStrings {
        public static string JoinStrings(string separator, params string[] strings) {
            return string.Join(", ", strings);
        }
    }
}
