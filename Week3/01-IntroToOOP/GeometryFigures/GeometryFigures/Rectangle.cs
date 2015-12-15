using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures {
    class Rectangle {
        private Point vertex1;
        private Point vertex2;
        private Point vertex3;
        private Point vertex4;

        public Rectangle(Point vertex1, Point vertex2) {
            if (vertex1.Equals(vertex2)) {
                throw new ArgumentException("Cannot create a Rectangle win zero size");
            }
            else {
                this.vertex1 = vertex1;
                this.vertex2 = vertex2;
                this.vertex3 = new Point(vertex2.X, vertex1.Y);
                this.vertex4 = new Point(vertex1.X, vertex2.Y);
            }
        }

        public Rectangle(Rectangle r) {
            this.vertex1 = r.vertex1;
            this.vertex2 = r.vertex2;
        }

        public Point Vertex1 {
            get {
                return vertex1;
            }
        }
        public Point Vertex2 {
            get {
                return vertex2;
            }
        }
        public Point Vertex3 {
            get {
                return vertex3;
            }
        }
        public Point Vertex4 {
            get {
                return vertex4;
            }
        }

        public LineSegment Up {
            get {
                LineSegment up = new LineSegment(Vertex4, Vertex2);
                Console.WriteLine("up: {0}", up.GetLength());
                return up;
            }
        }
        public LineSegment Down {
            get {
                LineSegment down = new LineSegment(Vertex1, Vertex3);
                Console.WriteLine("down: {0}", down.GetLength());
                return down;
            }
        }
        public LineSegment Left {
            get {
                LineSegment left = new LineSegment(Vertex1, Vertex4);
                Console.WriteLine("left: {0}", left.GetLength());
                return left;
            }
        }
        public LineSegment Right {
            get {
                LineSegment right = new LineSegment(Vertex2, Vertex3);
                Console.WriteLine("right: {0}", right.GetLength());
                return right;
            }
        }

        public LineSegment Width {
            get {
                LineSegment width = new LineSegment(Vertex1, Vertex3);
                Console.WriteLine("width: {0}", width.GetLength());
                return width;
            }
        }

        public LineSegment Height {
            get {
                LineSegment height = new LineSegment(Vertex1, Vertex4);
                Console.WriteLine("height: {0}", height.GetLength());
                return height;
            }
        }

        public Point Center {
            get {
                Point center = new Point(Width.GetLength() / 2, Height.GetLength() / 2);
                Console.WriteLine("center: {0},{1}", center.X, center.Y);
                return center;
            }
        }

        public double GetPerimeter() {
            return Up.GetLength() + Down.GetLength() + Left.GetLength() + Right.GetLength();
        }

        public double GetArea() {
            return Up.GetLength() * Left.GetLength();
        }

        public override string ToString() {
            string output = string.Format("Rectangle properties: Rectangle[({0},{1}), ({2},{3})]", Vertex1, Vertex2, Width, Height);
            Console.WriteLine(output);
            return output;
        }

        public override bool Equals(object obj) {
            Rectangle r = obj as Rectangle;
            if ((System.Object)r == null) {
                return false;
            }
            return (this.Vertex1 == r.Vertex1) && (this.Vertex2 == r.Vertex2);
        }

        public static bool operator ==(Rectangle rect1, Rectangle rect2) {
            if (rect1.Equals(rect2))
                return true;
            else
                return false;
        }

        public static bool operator !=(Rectangle rect1, Rectangle rect2) {
            if (!rect1.Equals(rect2))
                return true;
            else
                return false;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 17;
                hash = hash * 23 + vertex1.GetHashCode();
                hash = hash * 23 + vertex2.GetHashCode();
                return hash;
            }
        }
    }
}
