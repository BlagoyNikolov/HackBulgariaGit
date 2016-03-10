using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary {
    public class Fish : Animal {
        public override void Eat() {
            Console.WriteLine("Eating..Fish");
        }

        public override void GiveBirth() {
            Console.WriteLine("GiveBirth..Fish");
        }

        public override void Move() {
            Swim();
        }

        public virtual void Swim() {
            Console.WriteLine("Fish swimming...");
        }
    }
}
