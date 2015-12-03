using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.ProblemsInvolvingMethods {
    class FactorielGenerator {
       public static IEnumerable<int> GenerateFactorials(int n) {
            int result = 1;
            for (int i = 1; i <= n; i++) {
                result *= i;
                Console.WriteLine(result);
            }
            yield return result;
        }
    }
}
