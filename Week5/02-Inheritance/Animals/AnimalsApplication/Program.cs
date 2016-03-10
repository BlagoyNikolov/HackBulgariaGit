using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalsLibrary;

namespace AnimalsApplication {
    class Program {
        static void Main(string[] args) {
            List<Animal> list = new List<Animal>();
            list.Add(new Cat());
            list.Add(new Dog());
            list.Add(new Crocodile());
            list.Add(new Owl());
            list.Add(new Shark());

            foreach (var animal in list) {
                animal.Move();
                animal.Eat();
                animal.GiveBirth();

            }
        }
    }
}
