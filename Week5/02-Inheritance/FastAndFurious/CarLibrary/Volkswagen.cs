using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary {
    class Volkswagen : GermanCars {

        protected override int GetMileage() {
            return mileage;
        }

        protected override bool IsEcoFriendly(bool testing) {
            if (testing) {
                return true;
            }
            else {
                return testing;
            }
        }
    }
}
