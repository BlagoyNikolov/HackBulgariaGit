using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary {
    public class Owl : Birds {
        public override void Greet() {
            Console.WriteLine("ooooooooowwwwwwwwwwllllll");
        }

        public override void Eat() {
            Console.WriteLine("eating..Owl");
        }

        public override void GiveBirth() {
            Console.WriteLine("GiveBirth..Owl");
        }

        public override void Fly() {
            Console.WriteLine("Owl flying");
        }

        public override void MakeNest() {
            Console.WriteLine("Making nest");
        }
    }
}
