using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary {
    public class Ellipse : Shape {
        private double radiusX;
        private double radiusY;
        private Point center;

        public Ellipse(double radiusX, double radiusY, Point center) {
            this.radiusX = radiusX;
            this.radiusY = radiusY;
            this.center = center;
        }

        public double RadiusX { get { return radiusX; } set { radiusX = value; }}
        public double RadiusY { get { return radiusY; } set { radiusY = value; } }
        public Point Center { get { return center; } set { center = value; } }



        public override double GetPerimeter() {
            //2πSqrt((r1² + r2²) / 2)
            return 2 * Math.PI * Math.Sqrt((Math.Pow(RadiusX,2) + Math.Pow(RadiusY,2)) / 2);
        }

        public override double GetArea() {
            return Math.PI * RadiusX * RadiusY;
        }

        public override string ToString() {
            return string.Format("Ellipse: rx: {0}, ry: {1}, perimeter: {2}, area: {3}", RadiusX, RadiusY, GetPerimeter(), GetArea());
        }

        public override void Move(double x, double y) {
            Center.Move(x, y);
        }
    }
}
