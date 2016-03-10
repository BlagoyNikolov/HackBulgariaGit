using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary {
    class BMW : GermanCars {
        protected override int GetMileage() {
            return mileage;
        }

        protected override bool IsEcoFriendly(bool testing) {
            return true;
        }
    }
}
