using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotify_Property_Changed {
    class Program {
        static void Main(string[] args) {
            List<Car> cars = new List<Car>() {
                new Car("BMW", "M3", 420),
                new Car("Audi", "RS4", 450),
                new Car("Skoda", "Octavia", 190)
            };

            cars[0].PropertyChanged += Program_PropertyChanged;
            cars[1].PropertyChanged += Program_PropertyChanged;
            cars[2].PropertyChanged += Program_PropertyChanged;

            cars[0].changeBrand("Alpina");
            cars[0].changeModel("D3");
            cars[0].changePower(390);

            cars[1].changeBrand("Mercedess");
            cars[1].changeModel("S600");
            cars[1].changePower(590);
        }

        private static void Program_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            Console.WriteLine("Changed property: " + e.PropertyName);
            Console.WriteLine("Object hash code: " + sender.GetHashCode());
            Console.WriteLine("Property hash code: " + e.GetHashCode() + '\n');
        }
    }
}

