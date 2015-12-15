using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk {
    public class Bill {
        private int amount;

        public Bill(int amount) {
            this.amount = amount;
        }

        public override string ToString() {
            return string.Format("{0}$ bill", amount);
        }

        public override bool Equals(object obj) {
            Bill b = obj as Bill;
            if ((System.Object)b == null) {
                return false;
            }
            else {
                if (this.amount == b.amount) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        public static bool operator ==(Bill bill1, Bill bill2) {
            if (bill1.Equals(bill2))
                return true;
            else
                return false;
        }

        public static bool operator !=(Bill bill1, Bill bill2) {
            if (!bill1.Equals(bill2))
                return true;
            else
                return false;
        }

        public int Value() {
            return amount;
        }

        public static explicit operator int (Bill bill) {
            return bill.Value();
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 17;
                hash = hash * 23 + amount.GetHashCode();
                return hash;
            }
        }
    }
}
