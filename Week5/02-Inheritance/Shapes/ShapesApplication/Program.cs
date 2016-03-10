using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesLibrary;

namespace ShapesApplication {
    class Program {
        static void Main(string[] args) {
            Point v1 = new Point(0, 0);
            Point v2 = new Point(4, 0);
            Point v3 = new Point(4, 3);

            Square square = new Square(5, new Point(0, 0));
            Console.WriteLine(square.Width);
            square.Height = 8;
            Console.WriteLine(square.Width);
            Console.WriteLine(square.ToString());

            Ellipse el = new Ellipse(5, 3, new Point(0, 0));
            Console.WriteLine(el.ToString());

            Circle circ = new Circle(5, new Point(0, 0));
            Console.WriteLine(circ.RadiusX);
            circ.RadiusY = 8;
            Console.WriteLine(circ.RadiusX);
            Console.WriteLine(circ.ToString());

            Triangle t = new Triangle(v1, v2, v3, new Point(0, 0));
            Console.WriteLine(t.ToString());

            Console.WriteLine(t.Center);
            t.Move(1, 1);
            Console.WriteLine(t.Center);

        }
    }
}
