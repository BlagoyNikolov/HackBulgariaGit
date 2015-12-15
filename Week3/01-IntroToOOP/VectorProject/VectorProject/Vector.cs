using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorProject {
    class Vector {
        readonly int[] coordinates;

        public Vector(params int[] coordinates) {
            this.coordinates = coordinates;
        }

        public Vector(Vector v) {
            this.coordinates = v.coordinates;
        }

        public int this[int index] {
            get { return coordinates[index]; }
            set { coordinates[index] = value; }
        }

        public int Dimensionality {
            get {
                return coordinates.Length;
            }
        }

        public double GetVectorLength() {
            double length = 0;
            for (int i = 0; i < coordinates.Length; i++) {
                length += Math.Pow(coordinates[i], 2);
            }
            return Math.Sqrt(length);
        }

        public override string ToString() {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < coordinates.Length; i++) {
                output.Append(coordinates[i] + " ");
            }
            return output.ToString();
        }

        public override bool Equals(object obj) {
            Vector v = obj as Vector;
            if ((System.Object)v == null) {
                return false;
            }
            else {
                if (this.coordinates.Length == v.coordinates.Length) {
                    for (int i = 0; i < v.coordinates.Length; i++) {
                        if (this.coordinates[i] == v.coordinates[i]) {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public static bool operator ==(Vector vector1, Vector vector2) {
            if (vector1.Equals(vector2))
                return true;
            else
                return false;
        }

        public static bool operator !=(Vector vector1, Vector vector2) {
            if (!vector1.Equals(vector2))
                return true;
            else
                return false;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 17;
                hash = hash * 23 + coordinates.GetHashCode();
                return hash;
            }
        }


        public static Vector operator +(Vector vector1, Vector vector2) {
            int[] tempArray = new int[vector1.Dimensionality];
            if (vector1.Dimensionality.Equals(vector2.Dimensionality)) {
                for (int i = 0; i < vector1.Dimensionality; i++) {
                    tempArray[i] = vector1.coordinates[i] + vector2.coordinates[i];
                }
            }
            return new Vector(tempArray);
        }

        public static Vector operator -(Vector vector1, Vector vector2) {
            int[] tempArray = new int[vector1.Dimensionality];
            if (vector1.coordinates.Length.Equals(vector2.Dimensionality)) {
                for (int i = 0; i < vector1.Dimensionality; i++) {
                    tempArray[i] = vector1.coordinates[i] - vector2.coordinates[i];
                }
            }
            return new Vector(tempArray);
        }

        public static Vector operator +(Vector vector1, int scalar) {
            int[] tempArray = new int[vector1.Dimensionality];
            for (int i = 0; i < vector1.Dimensionality; i++) {
                tempArray[i] = vector1.coordinates[i] + scalar;
            }
            return new Vector(tempArray);
        }

        public static Vector operator -(Vector vector1, int scalar) {
            int[] tempArray = new int[vector1.Dimensionality];
            for (int i = 0; i < vector1.Dimensionality; i++) {
                tempArray[i] = vector1.coordinates[i] - scalar;
            }
            return new Vector(tempArray);
        }

        public static Vector operator *(Vector vector1, int scalar) {
            int[] tempArray = new int[vector1.Dimensionality];
            for (int i = 0; i < vector1.Dimensionality; i++) {
                tempArray[i] = vector1.coordinates[i] * scalar;
            }
            return new Vector(tempArray);
        }

        public static Vector operator /(Vector vector1, int scalar) {
            int[] tempArray = new int[vector1.Dimensionality];
            for (int i = 0; i < vector1.Dimensionality; i++) {
                tempArray[i] = vector1.coordinates[i] / scalar;
            }
            return new Vector(tempArray);
        }

        public static Vector operator *(Vector vector1, Vector vector2) {
            int[] tempArray = new int[vector1.Dimensionality];
            if (vector1.Dimensionality.Equals(vector2.coordinates.Length)) {
                for (int i = 0; i < vector1.Dimensionality; i++) {
                    tempArray[i] = vector1.coordinates[i] * vector2.coordinates[i];
                }
            }
            return new Vector(tempArray);
        }
    }
}