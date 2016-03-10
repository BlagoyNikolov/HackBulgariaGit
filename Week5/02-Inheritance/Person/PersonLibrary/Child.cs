using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary {
    public class Child : Person {
        public Child(bool gender) : base(gender) { }
        public Child(bool gender, List<Toy> toys) : base(gender) {
            this.toys = toys;
        }

        List<Toy> toys;

        public override void DailyStuff() {
            Console.WriteLine("Playing");
        }
        public override string ToString() {
            if (toys != null) {
                return String.Format("Child: woman: {0} and has {1} toys", IsWoman, toys.Count);
            }
            else {
                return String.Format("Child: woman: {0}", IsWoman);
            }
        }
    }
}
