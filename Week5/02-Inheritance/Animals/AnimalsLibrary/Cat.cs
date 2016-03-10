﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLibrary {
    public class Cat : Mammals {
        public override void Greet() {
            Console.WriteLine("meow..");
        }

        public override void Eat() {
            Console.WriteLine("Eating.. cat");
        }

        public override void GiveBirth() {
            Console.WriteLine("Giving birth.. cat");
        }

        public override void Move() {
            Console.WriteLine("Moving.. cat");
        }
    }
}
