using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BuiltInClasses {
    class PolygonArea {
        public static float CalcArea(PointF[] points) {
            float area = 0;
            for (int i = 0; i < points.Count() - 1; i++) {
                area += (points[i + 1].X - points[i].X) * (points[i + 1].Y + points[i].Y);
            }
            area = Math.Abs(area / 2);
            Console.WriteLine(area);
            return area;
        }
    }
}
