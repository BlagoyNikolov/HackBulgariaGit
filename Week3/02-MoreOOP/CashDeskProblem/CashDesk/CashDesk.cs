using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk {
    public class CashDesk {
        private Dictionary<Bill, int> billDict = new Dictionary<Bill, int>();

        public void TakeMoney(Bill bill) {
            if (billDict.ContainsKey(bill))
                billDict[bill]++;
            else
                billDict.Add(bill, 1);
        }

        public void TakeMoney(BatchBill batch) {
            foreach (Bill bill in batch) {
                if (billDict.ContainsKey(bill))
                    billDict[bill]++;
                else
                    billDict.Add(bill, 1);
            }
        }

        public int Total() {
            int sum = 0;
            foreach (var item in billDict) {
                  sum += item.Key.Value() * item.Value;
            }
            return sum;
        }

        public void Inspect() {
            var Bills = from pair in billDict orderby pair.Key.Value() ascending select pair;
            foreach (var pair in Bills) {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }

        public override string ToString() {
            return string.Format("We have a total of {0}$ in the desk", Total());
        }
    }
}
