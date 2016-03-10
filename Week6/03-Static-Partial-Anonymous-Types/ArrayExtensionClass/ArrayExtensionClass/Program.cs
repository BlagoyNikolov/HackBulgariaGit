using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayExtensionLibrary;

namespace ArrayExtensionClass {
    class Program {
        static void Main(string[] args) {
            List<int> numbers = new List<int>() { 1, 5, 8, 7, 65, 48, 6 };
            List<int> moreNumbers = new List<int>() { 4, 65, 8, 7, 98, 45, 6, 7 };

            Console.WriteLine("Intersect");
            foreach (var item in ArrayExtension.Intersect(numbers, moreNumbers)) {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nUnion");
            foreach (var item in ArrayExtension.Union(numbers, moreNumbers)) {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nUnionAll");
            foreach (var item in ArrayExtension.UnionAll(numbers, moreNumbers)) {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nJoin");
            Configuration config = new Configuration();
            char c = config.GetReplacingValue();
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Replacing value is: {0} ({1})", c, (int) c);
            List<string> listOfStrings = new List<string>() { "TEST", "STRING", "WORD", "ALPHABET", "SOMELONGWORDWITHLOTSOFLETTERSHERE", "abcdefghijklmnopqrstuvwxyz", "ABCDEFGHIJKLMNOPQRSTUVWXYZ" };
            string result = ArrayExtension.Join(listOfStrings);
            Console.WriteLine(result);
        }
    }
}
