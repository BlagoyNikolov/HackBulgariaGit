using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Lucas {
        public static int nthLucas(int n) {
            int n_0 = 2;
            int n_1 = 1;
            int temp = 0;
            for (int i = 3; i <= n; i++) {
                temp = n_0 + n_1;
                n_1 = n_0;
                n_0 = temp;
            }
            Console.WriteLine(temp);
            return temp;
        }

        public static int firstLucas(int n) {

            return 0;
        }
    }
}
