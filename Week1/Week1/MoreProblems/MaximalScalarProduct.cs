using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.MoreProblems {
    class MaximalScalarProduct {
        public static int MaxScalarProduct(List<int> v1, List<int> v2) {
            int sizeOfListV1 = v1.Count;
            int sizeOfListV2 = v2.Count;

            for (int i = sizeOfListV1 - 1; i >= 0; i--) {
                for (int j = 1; j <= i; j++) {
                    if (v1[j - 1] > v1[j]) {
                        int temp = v1[j - 1];
                        v1[j - 1] = v1[j];
                        v1[j] = temp;
                    }
                    if (v2[j - 1] > v2[j]) {
                        int temp = v2[j - 1];
                        v2[j - 1] = v2[j];
                        v2[j] = temp;
                    }

                }
            }

            int sum = 0;
            if (sizeOfListV1 != sizeOfListV2) {
                return 0;
            }
            else {
                for (int i = 0; i < sizeOfListV1; i++) {
                    int temp = v1[i] * v2[i];
                    sum += temp;
                }
                return sum;
            }
        }
    }
}
