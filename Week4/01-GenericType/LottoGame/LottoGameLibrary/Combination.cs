using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGameLibrary {
    public class Combination<T, U> {
        private readonly T firstT;
        private readonly T secondT;
        private readonly T thirdT;
        private readonly U firstU;
        private readonly U secondU;
        private readonly U thirdU;

        public Combination(T firstT, T secondT, T thirdT, U firstU, U secondU, U thirdU) {
            this.firstT = firstT;
            this.secondT = secondT;
            this.thirdT = thirdT;
            this.firstU = firstU;
            this.secondU = secondU;
            this.thirdU = thirdU;
        }

        public T FirstT { get; set; }
        public T SecondT { get; set; }
        public T ThirdT { get; set; }
        public T FirstU { get; set; }
        public T SecondU { get; set; }
        public T ThirdU { get; set; }

        public override bool Equals(object obj) {
            Combination<T, U> obj1 = this;
            Combination<T, U> obj2 = (Combination<T, U>)obj;

            if (obj1.FirstT.Equals(obj2.FirstT) && obj1.SecondT.Equals(obj2.SecondT) && obj1.ThirdT.Equals(obj2.ThirdT)) {
                if (obj1.FirstU.Equals(obj2.FirstU) && obj1.SecondU.Equals(obj2.SecondU) && obj1.ThirdU.Equals(obj2.ThirdU))
                    return true;
                else return false;
            }
            else
                return false;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 17;
                hash = hash * 23 + firstT.GetHashCode();
                hash = hash * 23 + secondT.GetHashCode();
                hash = hash * 23 + thirdT.GetHashCode();
                hash = hash * 23 + firstU.GetHashCode();
                hash = hash * 23 + secondU.GetHashCode();
                hash = hash * 23 + thirdU.GetHashCode();
                return hash;
            }
        }
    }
}
