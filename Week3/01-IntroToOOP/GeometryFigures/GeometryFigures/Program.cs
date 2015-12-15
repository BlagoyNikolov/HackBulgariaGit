using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures {
    class Program {
        static void Main(string[] args) {
            Point point = new Point();
            Point point1 = new Point(5, 4);
            Point point2 = new Point(point1);
            Point point3 = new Point(5, 4);
            Point point4 = new Point(8, 6);
            Point point5 = new Point(4, 0);
            Point point6 = new Point(0, 5);
            Point point7 = new Point(6, 4);

            point.ToString();
            point1.ToString();
            point2.ToString();
            point3.ToString();
            point4.ToString();

            Console.WriteLine(point1.Equals(point3)); //true
            Console.WriteLine(point2.Equals(point1)); //true
            Console.WriteLine(point3.Equals(point4)); //false

            Console.WriteLine(point1 == point); //false
            Console.WriteLine(point1 == point3); //true
            Console.WriteLine(point1 == point4); //false
            Console.WriteLine(point1 == point2); //true

            Console.WriteLine(point1 != point2); //false
            Console.WriteLine(point1 != point3); //false
            Console.WriteLine(point1 != point4); //true

            LineSegment line = new LineSegment(point, point1);
            Console.WriteLine(line.GetLength());
            line.ToString();

            LineSegment line1 = new LineSegment(point, point4);
            Console.WriteLine(line1.GetLength());
            line1.ToString();

            Console.WriteLine(line.Equals(line1));

            LineSegment line2 = new LineSegment(point5, point6);
            Console.WriteLine(line2.GetLength());
            line2.ToString();

            Console.WriteLine(line == line2);
            Console.WriteLine(line != line2);

            Console.WriteLine(line > line1);
            Console.WriteLine(line1 >= 10.0);

            Rectangle alpha = new Rectangle(point, point7);
            Console.WriteLine(alpha.Up);
            Console.WriteLine(alpha.Down);
            Console.WriteLine(alpha.Left);
            Console.WriteLine(alpha.Right);
            Console.WriteLine(alpha.Width);
            Console.WriteLine(alpha.Height);
            Console.WriteLine(alpha.Center);
            Console.WriteLine(alpha.GetPerimeter());
            Console.WriteLine(alpha.GetArea());
            alpha.ToString();

            Rectangle beta = new Rectangle(point, point7);
            Console.WriteLine(beta.Up);
            Console.WriteLine(beta.Down);
            Console.WriteLine(beta.Left);
            Console.WriteLine(beta.Right);
            Console.WriteLine(beta.Width);
            Console.WriteLine(beta.Height);
            Console.WriteLine(beta.Center);
            Console.WriteLine(beta.GetPerimeter());
            Console.WriteLine(beta.GetArea());
            beta.ToString();

            Console.WriteLine(alpha == beta);
            Console.WriteLine(alpha != beta);
            Console.WriteLine(alpha.Equals(beta));
        }
    }
}

