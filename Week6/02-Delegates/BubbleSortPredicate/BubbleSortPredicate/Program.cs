using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortPredicate {
    public delegate bool ComparerDelegate(int x, int y);

    public static class Program {
        public static bool Comparer(int x, int y) {
            return (x - y) > 0;
        }

        public static IList<int> BubbleSort(this IList<int> list, ComparerDelegate comparer) {
            for (int i = list.Count; i >= 0; i--) {
                for (int j = 1; j < i; j++) {
                    if (comparer(list[j - 1], list[j])) {
                        int temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }

        static void Main(string[] args) {
            List<int> list = new List<int>() { 8, 5, 1, 4, 2, 7, 8, 3, 9, 6 };
            foreach (var item in list) {
                Console.Write("{0} ", item);
            }

            list.BubbleSort(Comparer);

            Console.WriteLine();
            foreach (var item in list) {
                Console.Write("{0} ", item);
            }
        }
    }
}
