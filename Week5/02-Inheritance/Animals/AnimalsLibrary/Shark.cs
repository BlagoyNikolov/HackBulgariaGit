using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary {
    public class Shark : Fish {
        public override void Eat() {
            Console.WriteLine("Eating..Shark");
        }

        public override void GiveBirth() {
            Console.WriteLine("GiveBirth..Shark");
        }

        public override void Swim() {
            Console.WriteLine("Shark swimming...");
        }
    }
}
