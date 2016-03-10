using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary {
    public class Triangle : Shape {

        public Triangle(Point Vertex1, Point Vertex2, Point Vertex3, Point Center) {
            this.Vertex1 = Vertex1;
            this.Vertex2 = Vertex2;
            this.Vertex3 = Vertex3;
            this.Center = Center;
        }

        public Point Vertex1 { get; set; }
        public Point Vertex2 { get; set; }
        public Point Vertex3 { get; set; }
        public Point Center { get; set; }


        public override double GetArea() {
            double first = Math.Sqrt(Math.Pow((Vertex2.X - Vertex1.X), 2) + Math.Pow((Vertex2.Y - Vertex1.Y), 2));
            double second = Math.Sqrt(Math.Pow((Vertex3.X - Vertex2.X), 2) + Math.Pow((Vertex3.Y - Vertex2.Y), 2));
            double third = Math.Sqrt(Math.Pow((Vertex1.X - Vertex3.X), 2) + Math.Pow((Vertex1.Y - Vertex3.Y), 2));
            double p = (first + second + third) / 2;
            return Math.Sqrt(p * (p - first) * (p - second) * (p - third));
        }

        public override double GetPerimeter() {
            double first = Math.Sqrt(Math.Pow((Vertex2.X - Vertex1.X), 2) + Math.Pow((Vertex2.Y - Vertex1.Y), 2));
            double second = Math.Sqrt(Math.Pow((Vertex3.X - Vertex2.X), 2) + Math.Pow((Vertex3.Y - Vertex2.Y), 2));
            double third = Math.Sqrt(Math.Pow((Vertex1.X - Vertex3.X), 2) + Math.Pow((Vertex1.Y - Vertex3.Y), 2));
            return first + second + third;
        }

        public override string ToString() {
            return string.Format("Triangle: perimeter: {0}, area: {1}", GetPerimeter(), GetArea());
        }

        public override void Move(double x, double y) {
            Center.Move(x, y);
        }
    }
}
