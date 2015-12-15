using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BuiltInClasses {
    class BankAccountBalance {
        public static void Balance(string filename) {
            File.ReadAllText(filename);
            Console.WriteLine(File.ReadAllText(filename));
        }
    }
}
