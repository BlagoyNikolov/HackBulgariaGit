using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk {
    public class BatchBill : IEnumerable {
        public List<Bill> list;
        public int position = -1;

        public BatchBill(List<Bill> list) {
            this.list = list;
        }

        public int Count() {
            return list.Count;
        }

        public int Total() {
            int sum = 0;
            foreach (var item in list) {
                sum += item.Value();
            }
            return sum;
        }

        public override string ToString() {
            return string.Format("The number of bills: {0} and the total sum of the batch is: {1}", Count(), Total());
        }

        public IEnumerator GetEnumerator() {
            return list.GetEnumerator();
        }
    }
}
