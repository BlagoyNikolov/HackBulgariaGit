using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sort;

namespace SortAndSearchTest {
    class Program {
        static void Main(string[] args) {

            List<int> list = new List<int>() { 8, 5, 1, 4, 2, 7, 8, 3, 9, 6 };
            foreach (var item in list) {
                Console.Write("{0} ", item);
            }

            list.BubbleSort(new MyIntComparer());

            Console.WriteLine();
            foreach (var item in list) {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            List<int> list1 = new List<int>() { 9, 0, 5, 1, 7, 3, 8, 3, 2, 4 };
            foreach (var item in list1) {
                Console.Write("{0} ", item);
            }

            list1.SelectionSort(new MyIntComparer());

            Console.WriteLine();
            foreach (var item in list1) {
            Console.Write("{0} ", item);
            }

            Console.WriteLine();

            int? first = 17;
            int? second = 7;
            int int1 = 25;
            int int2 = 15;
            string str1 = "Hello!!!!!!";
            string str2 = "World!";
            LastDigitComparer LDcomparer = new LastDigitComparer();
            OddEvenComparer OEcomparer = new OddEvenComparer();
            StringLengthComparer STRLENcmp = new StringLengthComparer();
            ReverseComparer<int> Rcmp = new ReverseComparer<int>();
            Console.WriteLine("last digit comp: " + LDcomparer.Compare(int1, int2));
            Console.WriteLine("string length diff: " + STRLENcmp.Compare(str1, str2));
            Console.WriteLine("odd even: " + OEcomparer.Compare(first, second));
            Console.WriteLine("reverse: " + Rcmp.Compare(int1, int2));
            Console.WriteLine();
        }

        class MyIntComparer : IComparer<int> {
            public int Compare(int x, int y) {
                return x - y;
            }
        }

        class LastDigitComparer : IComparer<int> {
            public int Compare(int x, int y) {
                return x % 10 - y % 10;
            }
        }

        class StringLengthComparer : IComparer<string> {
            public int Compare(string x, string y) {
                int lengthX, lengthY;
                if (x == null) {
                    lengthX = 0;
                }
                else {
                    lengthX = x.Length;
                }
                if (y == null) {
                    lengthY = 0;
                }
                else {
                    lengthY = y.Length;
                }
                return lengthX - lengthY;
            }
        }

        class OddEvenComparer : IComparer<int?> {
            public int Compare(int? x, int? y) {
                if (x != null && y != null) {
                    if (x % 2 == 0 && y % 2 == 0) {
                        return (int)x - (int)y;
                    }
                    else if (x % 2 == 1 && y % 2 == 0) {
                        return (int)y - (int)x;
                    }
                    else if (x % 2 == 0 && y % 2 == 1) {
                        return (int)y;
                    }
                    else {
                        return (int)x;
                    }
                }
                else {
                    if (x == null && y == null) {
                        return 0;
                    }
                    else if (x == null) {
                        return (int)y;
                    }
                    else
                        return (int)x;
                }
            }
        }

        class ReverseComparer<T> : IComparer<T> {
            public int Compare(T firstNumber, T secondNumber) {
                return Comparer<T>.Default.Compare(firstNumber, secondNumber);
            }
        }
    }
}

