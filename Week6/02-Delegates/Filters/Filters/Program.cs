using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters {
    public delegate bool FilterDelegate<T>(T numbers);

    class Program {
        public static bool PositiveFilter(int numbers) {
            return numbers > 0;
        }

        public static bool NegativeFilter(int numbers) {
            return numbers < 0;
        }

        static List<T> FilterCollection<T>(List<T> original, FilterDelegate<T> filter) {
            List<T> temp = new List<T>();
            for (int i = 0; i < original.Count; i++) {
                if (filter(original[i])) {
                    temp.Add(original[i]);
                }
            }
            return temp;
        }

        static void Main(string[] args) {
            List<int> original = new List<int>() { 0, 1, 2, -5, 15, -10, 124, -100 };
            List<int> filteredList = FilterCollection<int>(original, PositiveFilter);

            Console.Write("Original list: ");
            foreach (var item in original) {
                Console.Write(item + " ");
            }

            Console.Write("\nResult: ");
            foreach (var item in filteredList) {
                Console.Write(item + " ");
            }        
        }
    }
}
