using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary {
    abstract class GermanCars : Car {
        protected int mileage { get; set; }
        protected abstract int GetMileage();

    }
}
