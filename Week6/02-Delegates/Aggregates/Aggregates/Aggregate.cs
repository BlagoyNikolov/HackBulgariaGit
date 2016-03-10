using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates {
    public delegate T AggregateDelegate<T>(T x, T y);

    class Aggregate {

        static int Max(int x, int y) {
            if (x > y) {
                return x;
            }
            return y;
        }

        static int Min(int x, int y) {
            if (x < y) {
                return x;
            }
            return y;
        }

        static int Sum(int x, int y) {
            return x + y;
        }

        static int Product(int x, int y) {
            return x * y;
        }

        static int Average(int x, int y) {
            return (x + y) / 2;
        }

        static T AggregateCollection<T>(List<T> original, AggregateDelegate<T> aggregate) {
            T temp = original[0];
            for (int i = 1; i < original.Count; i++) {
                temp = aggregate(temp, original[i]);
            }
            return temp;
        }

        public static void Main(string[] args) {
            List<int> list = new List<int>() { 3, 8, 2, 6, 10 };
            foreach (var item in list) {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nMax: " + AggregateCollection(list, Max));
            Console.WriteLine("Min: " + AggregateCollection(list, Min));
            Console.WriteLine("Sum: " + AggregateCollection(list, Sum));
            Console.WriteLine("Product: " + AggregateCollection(list, Product));
            Console.WriteLine("Average: " + AggregateCollection(list, Average));
        }
    }
}
