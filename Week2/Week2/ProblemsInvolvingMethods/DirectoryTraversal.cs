using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.ProblemsInvolvingMethods {
    class DirectoryTraversal {
        public static IEnumerable<string> IterateDirectory(DirectoryInfo dir) {
            FileInfo[] files = dir.GetFiles("*", SearchOption.AllDirectories);
            DirectoryInfo[] directories = dir.GetDirectories("*", SearchOption.AllDirectories);

            foreach (var item in directories) {
                Console.WriteLine(item);
            }
            foreach (var item in files) {
                Console.WriteLine(item);
            }
            yield return files.ToString() + directories.ToString();
        }
    }
}
