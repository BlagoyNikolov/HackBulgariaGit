using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary {
    public abstract class Birds : Animal {
        public abstract void Greet();

        public override void Eat() {
            Console.WriteLine("eating..Bird");
        }

        public override void GiveBirth() {
            Console.WriteLine("GiveBirth..Bird");
        }

        public override void Move() {
            Fly();
        }

        public virtual void Fly() {
            Console.WriteLine("Bird flying");
        }

        public virtual void MakeNest() {
            Console.WriteLine("Making nest");
        }
    }
}
