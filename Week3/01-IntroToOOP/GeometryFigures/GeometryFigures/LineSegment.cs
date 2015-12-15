using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures {
    class LineSegment {
        private Point start;
        private Point end;

        public Point Start {
            get {
                return start;
            }
        }
        public Point End {
            get {
                return end;
            }
        }

        public LineSegment(Point start, Point end) {
            if (start.Equals(end)) {
                throw new ArgumentException("Cannot create a line segment with zero length");
            }
            else {
                this.start = start;
                this.end = end;
            }
        }

        public LineSegment(LineSegment l) {
            this.start = l.start;
            this.end = l.end;
        }

        public double GetLength() {
            return Math.Sqrt(Math.Pow((end.X - start.X), 2) + Math.Pow((end.Y - start.Y), 2)); ;
        }

        public override string ToString() {
            string output = string.Format("Line coordinates: Line[({0},{1}), ({2},{3})]", Start.X, Start.Y, End.X, End.Y);
            Console.WriteLine(output);
            return output;
        }

        public override bool Equals(object obj) {
            LineSegment l = obj as LineSegment;
            if ((System.Object)l == null) {
                return false;
            }
            return (this.Start == l.Start) && (this.End == l.End);
        }

        public static bool operator ==(LineSegment seg1, LineSegment seg2) {
            if (seg1.GetLength() == seg2.GetLength())
                return true;
            else
                return false;
        }

        public static bool operator !=(LineSegment seg1, LineSegment seg2) {
            if (seg1.GetLength() != seg2.GetLength())
                return true;
            else
                return false;
        }

        public static bool operator <(LineSegment seg1, LineSegment seg2) {
            if (seg1.GetLength() < seg2.GetLength())
                return true;
            else
                return false;
        }

        public static bool operator >(LineSegment seg1, LineSegment seg2) {
            if (seg1.GetLength() > seg2.GetLength())
                return true;
            else
                return false;
        }

        public static bool operator <=(LineSegment seg1, LineSegment seg2) {
            if (seg1.GetLength() <= seg2.GetLength())
                return true;
            else
                return false;
        }

        public static bool operator >=(LineSegment seg1, LineSegment seg2) {
            if (seg1.GetLength() >= seg2.GetLength())
                return true;
            else
                return false;
        }

        public static bool operator <(LineSegment seg1, double length) {
            if (seg1.GetLength() < length)
                return true;
            else
                return false;
        }

        public static bool operator >(LineSegment seg1, double length) {
            if (seg1.GetLength() > length)
                return true;
            else
                return false;
        }

        public static bool operator <=(LineSegment seg1, double length) {
            if (seg1.GetLength() <= length)
                return true;
            else
                return false;
        }

        public static bool operator >=(LineSegment seg1, double length) {
            if (seg1.GetLength() >= length)
                return true;
            else
                return false;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 17;
                hash = hash * 23 + start.GetHashCode();
                hash = hash * 23 + end.GetHashCode();
                return hash;
            }
        }
    }
}
