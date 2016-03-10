using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary {
    public abstract class Mammals : Animal {
        public abstract void Greet();

        public override void Eat() {
            Console.WriteLine("Eating.. mamal");
        }

        public override void GiveBirth() {
            Console.WriteLine("Giving birth.. mamal");
        }

        public override void Move() {
            Console.WriteLine("Moving.. mamal");
        }
    }
}
