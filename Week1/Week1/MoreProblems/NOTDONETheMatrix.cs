using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.MoreProblems {
    class NOTDONETheMatrix {
        public static int MatrixBombing(int[,] m, int target) {
            int damage = 0;

            int row = m.GetLength(0);
            int col = m.GetLength(1);
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if(target == m[i, j]) {
                        m[i, j] = target;

                        m[i - 1, j - 1] -= target;
                        m[i-1, j] -= target;
                        m[i-1, j+1] -= target;
                        m[i, j-1] -= target;
                        m[i, j+1] -= target;

                        m[i+1, j-1] -= target;
                        m[i+1, j] -= target;
                        m[i+1, j+1] -= target;

                    }

                }
            }

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }

            return damage;
        }
    }
}
