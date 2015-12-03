using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Week2.ProblemsInvolvingMethods {
    class InflateRectangle {
        public static void Inflate(ref Rectangle rect, Size inflateSize) {
            Rectangle temp = new Rectangle();
            rect.X -= inflateSize.Width;
            temp.X = rect.X;
            rect.Y -= inflateSize.Height;
            temp.Y = rect.Y;
            rect.Width += inflateSize.Width * 2;
            temp.Width = rect.Width;
            rect.Height += inflateSize.Height * 2;
            temp.Height = rect.Height;

            rect = temp;

            Console.WriteLine("x: " + rect.X + " y: " + rect.Y + " w: " + rect.Width + " h: " + rect.Height);

        }
    }
}
