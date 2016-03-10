using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort {
    public static class SortAndSearchExtensions {
        public static IList<T> BubbleSort<T>(this IList<T> list, IComparer<T> comparer) {
            for (int i = list.Count; i >= 0; i--) {
                for (int j = 1; j < i; j++) {
                    if (comparer.Compare(list[j - 1], list[j]) > 0) {
                        T temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }

        public static IList<T> SelectionSort<T>(this IList<T> list, IComparer<T> comparer) {
            for (int i = 0; i < list.Count - 1; i++) {
                T min = list[i];
                int imin = i;
                for (int j = i + 1; j < list.Count; j++) {
                    if (comparer.Compare(min, list[j]) > 0) {
                        min = list[j];
                        imin = j;
                    }
                }
                list[imin] = list[i];
                list[i] = min;
            }
            return list;
        }

        //public static IList<T> QuickSort<T>(this IList<T> list, IComparer<T> comparer) {

            //void quicksort(int lo, int hi) {
            //    int i = lo, j = hi, h;
            //    int x = a[(lo + hi) / 2];
            //    do {
            //        while (a[i] < x) i++;
            //        while (a[j] > x) j--;
            //        if (i <= j) {
            //            h = a[i];
            //            a[i] = a[j];
            //            a[j] = h;
            //            i++; j--;
            //        }
            //    } while (i <= j);
            //    if (lo < j)
            //        quicksort(lo, j);
            //    if (i < hi)
            //        quicksort(i, hi);
            //}

        }
    }
