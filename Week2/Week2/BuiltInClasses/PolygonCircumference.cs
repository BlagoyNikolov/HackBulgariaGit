using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Week2.BuiltInClasses {
    class PolygonCircumference {
        public static float CalcCircumference(PointF[] points) {
            float circumference = 0;
            for (int i = 0; i < points.Count() - 1; i++) {
                circumference += calculateSides(points[i], points[i + 1]);
            }
            circumference += calculateSides(points[points.Count() - 1], points[0]);
            Console.WriteLine(circumference);
            return circumference;
        }

        public static float calculateSides(PointF a, PointF b) {
            float Ax = a.X;
            float Ay = a.Y;
            float Bx = b.X;
            float By = b.Y;

            float side = (float)Math.Sqrt((Ay - By) * (Ay - By) + (Ax - Bx) * (Ax - Bx));
            return side;
        }
    }
}
