using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro {
    class Fractions {
        private int numerator;
        private int denominator;

        public Fractions(int numerator, int denominator) {
            this.numerator = numerator;

            if (denominator == 0) {
                throw new ArgumentException("Denominator cannot be 0");
            }
            else {
                this.denominator = denominator;
            }
        }

        public int Numerator {
            get;
            set;
        }

        public int Denominator {
            get { return denominator; }
            set {
                if (value != 0) {
                    denominator = value;
                }
            }
        }

        public override string ToString() {
            int result = numerator / denominator;
            Console.WriteLine(result.ToString());
            return result.ToString();
        }

        public override bool Equals(System.Object obj) {
            Fractions f = obj as Fractions;
            if ((System.Object) f == null) {
                return false;
            }
            else if (Simplify(f) == ) {
                return true;
            }
        }

        public static bool operator ==(Fractions fraction1, Fractions fraction2) {
            if (((fraction1.numerator / fraction1.denominator).ToString()).Equals((fraction2.numerator / fraction2.denominator).ToString()))
                return true;
            else
                return false;
        }

        public static bool operator !=(Fractions fraction1, Fractions fraction2) {
            if (!((fraction1.numerator / fraction1.denominator).ToString()).Equals((fraction2.numerator / fraction2.denominator).ToString()))
                return true;
            else
                return false;
        }

        public static bool operator +(Fractions fraction1, Fractions fraction2) {

        }

        public static bool operator -(Fractions fraction1, Fractions fraction2) {

        }
        public static bool operator *(Fractions fraction1, Fractions fraction2) {

        }
        public static bool operator /(Fractions fraction1, Fractions fraction2) {

        }

        public static bool operator +(Fractions fraction1, double number) {

        }

        public static bool operator -(Fractions fraction1, double number) {

        }
        public static bool operator *(Fractions fraction1, double number) {

        }
        public static bool operator (Fractions fraction1, double number) {

        }

        public override int GetHashCode() {
            unchecked {
                int hash = 17;
                hash = hash * 23 + numerator.GetHashCode();
                hash = hash * 23 + denominator.GetHashCode();
                return hash;
            }
        }




        void Simplify(Fractions f) {
             int numbers = f.numerator / f.denominator;
            int gcd = GCD(numbers);
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] /= gcd;
        }
        int GCD(int a, int b) {
            while (b > 0) {
                int rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }
        int GCD(int[] args) {
            // using LINQ:
            return args.Aggregate((gcd, arg) => GCD(gcd, arg));
        }
    }
}