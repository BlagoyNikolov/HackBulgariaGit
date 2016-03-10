using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;

namespace PersonApplication {
    class Program {
        static void Main(string[] args) {
            Toy toy1 = new Toy("blue", 2);
            Toy toy2 = new Toy("red", 3);
            List<Toy> toys = new List<Toy>() { toy1, toy2 };
            Adult adult1 = new Adult(true);
            Child child1 = new Child(true);
            Child child2 = new Child(false);
            Child child3 = new Child(true, toys);
            List<Child> children = new List<Child>() { child1, child2, child3 };
            Adult adult2 = new Adult(false, children, true);
            Console.WriteLine(adult2.ToString());
            Console.WriteLine(adult1.ToString());
            Console.WriteLine(child3.ToString());
            Console.WriteLine(child1.ToString());
        }
    }
}
