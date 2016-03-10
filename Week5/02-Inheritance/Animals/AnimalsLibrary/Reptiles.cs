using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary {
    public abstract class Reptiles : Animal {
        public abstract void Greet();
        public Reptiles() {
            ConstTemp = false;
        }

        public override void Eat() {
            Console.WriteLine("Eating..Reptiles");
        }

        public override void GiveBirth() {
            Console.WriteLine("Giving birth..Reptiles");
        }

        public override void Move() {
            Console.WriteLine("Moving..Reptiles");
        }
    }
}
