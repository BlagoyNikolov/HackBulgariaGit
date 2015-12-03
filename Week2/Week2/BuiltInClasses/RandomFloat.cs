using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BuiltInClasses {
    class RandomFloat {
        public static void GenerateRandomMatrix(int rows, int columns, string fileName) {
            float[,] matrix = new float[rows, columns];
            System.Random random = new System.Random();
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("{0}x{1}", rows, columns);
            sb.AppendFormat("{0}x{1} {2}", rows, columns, Environment.NewLine);

            for (int i = 0; i < rows; ++i) {
                for (int j = 0; j < columns; ++j) {
                    matrix[i, j] = (float)((random.NextDouble() * 1000.0));
                    sb.AppendFormat(("{0:#,###.##}"), matrix[i, j].ToString("#,##0.00").PadLeft(8));
                    Console.Write(("{0:#,###.##}"), matrix[i, j].ToString("#,##0.00").PadLeft(8));
                }
                sb.Append(Environment.NewLine);
                Console.WriteLine();
            }
            File.WriteAllText(fileName, sb.ToString());
        }
    }
}
