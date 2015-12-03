using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.IntroductionToOOP {
    class Pair {
        private Time object1 { get; set; }
        private Time object2 { get; set; }

        public Pair(Time object1, Time object2) {
            this.object1 = object1;
            this.object2 = object2;
        }

        public static bool operator ==(Pair pair1, Pair pair2) {
            if (pair1.object1.ToString().Equals(pair2.object1.ToString()) && pair1.object2.ToString().Equals(pair2.object2.ToString()))
                return true;
            else
                return false;
        }

        public static bool operator !=(Pair pair1, Pair pair2) {
            if (!pair1.object1.ToString().Equals(pair2.object1.ToString()) || !pair1.object2.ToString().Equals(pair2.object2.ToString()))
                return true;
            else
                return false;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 17;
                hash = hash * 23 + object1.GetHashCode();
                hash = hash * 23 + object2.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(System.Object obj) {
            Pair p = obj as Pair;
            if((System.Object)p == null) {
                return false;
            }
            return (this.object1.year == p.object1.year) && (this.object2.year == p.object2.year);
        }

        public override string ToString() {
            string x = string.Format("{0}:{1}:{2} {3}.{4}.{5}", this.object1.hours, this.object1.minutes,
                this.object1.seconds, this.object1.day, this.object1.month, this.object1.year);

            string y = string.Format(" {0}:{1}:{2} {3}.{4}.{5}", this.object2.hours, this.object2.minutes,
                this.object2.seconds, this.object2.day, this.object2.month, this.object2.year);

            return x + y; ;
        }
    }
}