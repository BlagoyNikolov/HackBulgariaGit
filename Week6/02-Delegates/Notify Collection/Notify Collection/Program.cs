using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INotify_Property_Changed;

namespace Notify_Collection {
    class Program {
        static void Main(string[] args) {
            NotifyCollection<Car> list = new NotifyCollection<Car>();
            list.PropertyChanged += (s, e) => { Console.WriteLine(e.PropertyName); };
            Car BMW = new Car("BMW", "M3", 420);
            Car Audi = new Car("Audi", "RS4", 450);
            Car Skoda = new Car("Skoda", "Octavia", 190);
            list.Add(BMW);
            list.Add(Audi);
            list.Add(Skoda);
            list.RemoveAt(2);
            list.Contains(BMW);
            list.Remove(Audi);
            foreach (var item in list) {
                Console.WriteLine(item._brand + " ");
            }
        }
    }
}
