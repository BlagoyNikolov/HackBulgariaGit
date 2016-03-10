using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary {
    public class Crocodile : Reptiles {
        public override void Greet() {
            Console.WriteLine("Greetings.. croc");
        }

        public override void Eat() {
            Console.WriteLine("Eating.. Crocodile");
        }

        public override void GiveBirth() {
            Console.WriteLine("Giving birth.. Crocodile");
        }

        public override void Move() {
            Console.WriteLine("Moving.. Crocodile");
        }
    }
}
