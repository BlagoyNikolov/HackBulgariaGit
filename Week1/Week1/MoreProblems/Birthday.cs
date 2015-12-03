using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.MoreProblems {
    class Birthday {
        public static List<int> BirthdayRanges(List<int> birthdays, List<KeyValuePair<int, int>> ranges) {
            var numbers = new List<int>();
            int[] birth = birthdays.ToArray();
            int temp = 0;
            int rl = ranges.Count();

            for (int i = 0; i < rl; i++) {
                for (int j = 0; j < birth.Length; j++) {
                    if (ranges.ElementAt(i).Key <= birth[j] && ranges.ElementAt(i).Value >= birth[j]) {
                        temp++;
                    }
                }
                numbers.Add(temp);
                temp = 0;
            }

            for (int i = 0; i < rl; i++) {
                Console.Write(numbers.ElementAt(i) + " ");
            }
            return numbers;
        }
    }
}