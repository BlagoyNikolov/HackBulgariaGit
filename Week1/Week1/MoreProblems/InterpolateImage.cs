using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication2.MoreProblems {
    class InterpolateImage {
        public static void ResampleImage(Bitmap bitmap, Size newSize, string savePath) {
            float newWidth = (float)newSize.Width / bitmap.Width;
            float newHeight = (float)newSize.Height / bitmap.Height;

            Bitmap newBmp = new Bitmap(newSize.Width, newSize.Height);

            double currentX = 0;
            double currentY = 0;

            for (int i = 0; i < newBmp.Width; i++) {
                for (int j = 0; j < newBmp.Height; j++) {

                    currentX = Math.Round(i / newWidth);
                    currentY = Math.Round(j / newHeight);

                    if(bitmap.Width > currentX && bitmap.Height > currentY) {

                        Color pixel = bitmap.GetPixel((int)currentX, (int)currentY);
                        newBmp.SetPixel(i, j, pixel);
                    }
                }
            }
            newBmp.Save(savePath);
        }
    }
}
