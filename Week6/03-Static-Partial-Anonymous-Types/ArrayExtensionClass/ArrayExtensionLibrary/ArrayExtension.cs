using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensionLibrary {
    public static class ArrayExtension {
        private static readonly char ReplacingValue;

        static ArrayExtension() {
            ReplacingValue = new Configuration().GetReplacingValue();
        }

        public static List<T> Intersect<T>(List<T> firstList, List<T> secondList) {
            List<T> temp = new List<T>();
            foreach (var item in firstList) {
                if (secondList.Contains(item)) {
                    temp.Add(item);
                }
            }
            return temp;
        }

        public static List<T> UnionAll<T>(List<T> firstList, List<T> secondList) {
            List<T> temp = new List<T>();
            //temp.AddRange(firstList);
            //temp.AddRange(secondList);
            foreach (var item in firstList) {
                temp.Add(item);
            }
            foreach (var item in secondList) {
                temp.Add(item);
            }
            return temp;
        }

        public static List<T> Union<T>(List<T> firstList, List<T> secondList) {
            List<T> temp = new List<T>();
            foreach (var item in firstList) {
                temp.Add(item);
            }
            foreach (var item in secondList) {
                if (temp.Contains(item) == false) {
                    temp.Add(item);
                }
            }
            return temp;
        }

        public static string Join(List<string> list) {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list) {
                if (item.Contains(ReplacingValue)) {
                    sb.Append(item);
                }
            }
            return sb.ToString();
        }
    }
}
