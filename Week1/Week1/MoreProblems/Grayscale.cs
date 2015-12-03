using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication2.MoreProblems {
    class Grayscale {
        public static void GreyScaleImage(Bitmap bitmap, string savePath) {
            for (int i = 0; i < bitmap.Width; i++) {
                for (int j = 0; j < bitmap.Height; j++) {
                    Color pixel = bitmap.GetPixel(i, j);
                    int grayscale = (pixel.B + pixel.R + pixel.G) / 3;
                    Color newPixel = Color.FromArgb(grayscale, grayscale, grayscale);
                    bitmap.SetPixel(i, j, newPixel);
                }
            }
            bitmap.Save(savePath);
        }
    }
}
