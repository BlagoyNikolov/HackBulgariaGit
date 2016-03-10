using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary {
    public class Square : Rectangle {
        private double side;

        public Square(double side, Point center) : base(side, side, center) {
            this.side = side;
        }

        public double Side {
            get { return side; }
            set {
                side = value;
                Width = value;
                Height = value;
            }
        }

        public double Height {
            get { return base.Height; }
            set {
                base.Height = value;
                if (base.Width != base.Height) {
                    base.Width = value;
                }
                side = value;
            }
        }

        public double Width {
            get { return base.Width; }
            set {
                base.Width = value;
                if (base.Height != base.Width) {
                    base.Height = value;
                }
                side = value;
            }
        }

        public override string ToString() {
            return string.Format("Square: s: {0}, perimeter: {1}, area: {2}", Side, GetPerimeter(), GetArea());
        }
    }
}
