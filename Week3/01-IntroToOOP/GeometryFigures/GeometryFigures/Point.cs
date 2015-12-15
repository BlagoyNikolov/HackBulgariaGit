using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures {
    class Point {
        private double x, y;

        public double X {
            get {
                return x;
            }
        }
        public double Y {
            get {
                return y;
            }
        }

        public Point() {
            this.x = 0;
            this.y = 0;
        }

        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public Point(Point p) {
            this.x = p.X;
            this.y = p.Y;
        }

        public double Prop1 { get { return X; } }

        public double Prop2 { get { return Y; } }

        public static readonly Point origin = new Point(0, 0);

        public override string ToString() {
            string output = string.Format("Point coordinates: ({0},{1})", Prop1, Prop2);
            Console.WriteLine(output);
            return output;
        }

        public override bool Equals(object obj) {
            Point p = obj as Point;
            if ((System.Object)p == null) {
                return false;
            }
            return (this.X == p.X) && (this.Y == p.Y);
            
        }

        public static bool operator ==(Point point1, Point point2) {
            if ((point1.X.Equals(point2.X)) && (point1.Y.Equals(point2.Y)))
                return true;
            else
                return false;
        }

        public static bool operator !=(Point point1, Point point2) {
            if ((!point1.X.Equals(point2.X)) || (!point1.Y.Equals(point2.Y)))
                return true;
            else
                return false;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 17;
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                return hash;
            }
        }
    }
}
