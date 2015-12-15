using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorProject {
    class Program {
        static void Main(string[] args) {
            Vector vector = new Vector(1, 2, 3);
            Vector vector1 = new Vector(3, 4, 5);
            Console.WriteLine(vector.Dimensionality);
            Console.WriteLine("Vector length: " + vector.GetVectorLength());
            Console.WriteLine(vector.ToString());
            Console.WriteLine(vector.Equals(vector1));
            Console.WriteLine(vector == vector1);
            Console.WriteLine(vector != vector1);

            Console.WriteLine(vector + vector1);
            Console.WriteLine(vector - vector1);

            Console.WriteLine(vector + 5);
            Console.WriteLine(vector - 5);
            Console.WriteLine(vector * 5);
            Console.WriteLine(vector / 3);

            Console.WriteLine(vector * vector1);
        }
    }
}
