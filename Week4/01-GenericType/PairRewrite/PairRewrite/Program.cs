using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairRewrite {
    class Program {
        static void Main(string[] args) {
            PairGenerics<int, int> pair1 = new PairGenerics<int, int>(5, 10);
            PairGenerics<int, int> pair2 = new PairGenerics<int, int>(5, 10);
            PairGenerics<int, string> pair3 = new PairGenerics<int, string>(15, "test");
            PairGenerics<int, string> pair4 = new PairGenerics<int, string>(20, "test1");

            Console.WriteLine(pair1.ToString());
            Console.WriteLine(pair2.ToString());
            Console.WriteLine(pair3.ToString());
            Console.WriteLine(pair4.ToString());

            Console.WriteLine(pair1.Equals(pair2)); //true
            Console.WriteLine(pair1 == pair2); //true
            Console.WriteLine(pair1 != pair2); //false

            Console.WriteLine(pair3.Equals(pair4)); //false
            Console.WriteLine(pair3 == pair4); //false
            Console.WriteLine(pair3 != pair4); //true
        }
    }
}
