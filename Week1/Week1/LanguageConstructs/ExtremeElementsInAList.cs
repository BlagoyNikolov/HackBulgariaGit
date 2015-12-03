using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.LanguageConstructs {
    class ExtremeElementsInAList {
        public static int Min(int[] items) {
            int min = items[0];

            for (int i = 0; i < items.Length; i++) {
                if (items[i] < min) {
                    min = items[i];
                }
            }
            return min;
        }

        public static int Max(int[] items) {
            int max = items[0];

            for (int i = 0; i < items.Length; i++) {
                if (items[i] > max) {
                    max = items[i];
                }
            }
            return max;
        }

        public static int NthMin(int n, int[] items) {
            int nthMin = items[0];

            for (int i = 0; i < items.Length - 1; i++) {
                for (int j = i + 1; j < items.Length; j++) {
                    if (items[i] > items[j]) {
                        int temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }

            nthMin = items[n - 1];
            return nthMin;
        }

        public static int NthMax(int n, int[] items) {
            int NthMax = items[0];

            for (int i = 0; i < items.Length - 1; i++) {
                for (int j = i + 1; j < items.Length; j++) {
                    if (items[i] > items[j]) {
                        int temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }

            NthMax = items[items.Length - n];
            return NthMax;
        }
    }
}
