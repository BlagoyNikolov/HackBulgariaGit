using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary {
    public class Dog : Mammals {
        public override void Greet() {
            Console.WriteLine("bark..");
        }

        public override void Eat() {
            Console.WriteLine("Eating.. dog");
        }

        public override void GiveBirth() {
            Console.WriteLine("Giving birth.. dog");
        }

        public override void Move() {
            Console.WriteLine("Moving.. dog");
        }
    }
}
