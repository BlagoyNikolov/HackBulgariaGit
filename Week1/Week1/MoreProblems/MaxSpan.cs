using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.MoreProblems {
    class MaxSpanOfNumbers {
        public static int MaxSpan(List<int> numbers) {
            int sizeOfNumbers = numbers.Count;
            int span, index = 0;
            int[] tempArray = new int[sizeOfNumbers];

            for (int i = 0; i < sizeOfNumbers - 1; i++) {
                for (int j = sizeOfNumbers - 1; j > 0; j--) {
                    if (numbers[i] == numbers[j]) {
                        span = j - i + 1;
                        tempArray[index] = span;
                        index++;
                        break;
                    }
                    else {
                        span = 1;
                    }
                }
            }
            int defSpan = tempArray[tempArray.Length - 1];
            for (int i = 0; i < tempArray.Length - 1; i++) {
                if (tempArray[i] > defSpan) {
                    defSpan = tempArray[i];
                }
            }
            return defSpan;
        }
    }
}