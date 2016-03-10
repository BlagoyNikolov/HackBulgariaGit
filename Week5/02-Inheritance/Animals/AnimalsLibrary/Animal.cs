using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary {
    public abstract class Animal {
        public abstract void Move();
        public abstract void Eat();
        public abstract void GiveBirth();
        public bool ConstTemp = true;
    }
}
