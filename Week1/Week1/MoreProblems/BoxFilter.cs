using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication2.MoreProblems {
    class BoxFilter {
        public static void BlurImage(Bitmap bitmap, string savePath) {
            Bitmap newBmp = new Bitmap(bitmap.Width, bitmap.Height);
            int red = 0; int green = 0; int blue = 0;

            //top left
            red = (bitmap.GetPixel(0, 0).R + bitmap.GetPixel(0, 1).R + bitmap.GetPixel(1, 0).R + bitmap.GetPixel(1, 1).R) / 4;
            green = (bitmap.GetPixel(0, 0).G + bitmap.GetPixel(0, 1).G + bitmap.GetPixel(1, 0).G + bitmap.GetPixel(1, 1).G) / 4;
            blue = (bitmap.GetPixel(0, 0).B + bitmap.GetPixel(0, 1).B + bitmap.GetPixel(1, 0).B + bitmap.GetPixel(1, 1).B) / 4;
            Color pixel = Color.FromArgb(red, green, blue);
            newBmp.SetPixel(0, 0, pixel);

            //top right
            red = (bitmap.GetPixel(0, bitmap.Width - 2).R + bitmap.GetPixel(0, bitmap.Width - 1).R + bitmap.GetPixel(1, bitmap.Width - 2).R + bitmap.GetPixel(1, bitmap.Width - 1).R) / 4;
            green = (bitmap.GetPixel(0, bitmap.Width - 2).G + bitmap.GetPixel(0, bitmap.Width - 1).G + bitmap.GetPixel(1, bitmap.Width - 2).G + bitmap.GetPixel(1, bitmap.Width - 1).G) / 4;
            blue = (bitmap.GetPixel(0, bitmap.Width - 2).B + bitmap.GetPixel(0, bitmap.Width - 1).B + bitmap.GetPixel(1, bitmap.Width - 2).B + bitmap.GetPixel(1, bitmap.Width - 1).B) / 4;
            pixel = Color.FromArgb(red, green, blue);
            newBmp.SetPixel(bitmap.Width - 1, 0, pixel);

            //bottom left
            red = (bitmap.GetPixel(0, bitmap.Height - 2).R + bitmap.GetPixel(1, bitmap.Height - 2).R + bitmap.GetPixel(0, bitmap.Height - 1).R + bitmap.GetPixel(1, bitmap.Height - 1).R) / 4;
            green = (bitmap.GetPixel(0, bitmap.Height - 2).G + bitmap.GetPixel(1, bitmap.Height - 2).G + bitmap.GetPixel(0, bitmap.Height - 1).G + bitmap.GetPixel(1, bitmap.Height - 1).G) / 4;
            blue = (bitmap.GetPixel(0, bitmap.Height - 2).B + bitmap.GetPixel(1, bitmap.Height - 2).B + bitmap.GetPixel(0, bitmap.Height - 1).B + bitmap.GetPixel(1, bitmap.Height - 1).B) / 4;
            pixel = Color.FromArgb(red, green, blue);
            newBmp.SetPixel(0, bitmap.Height - 1, pixel);

            //bottom right
            red = (bitmap.GetPixel(bitmap.Width - 2, bitmap.Height - 2).R + bitmap.GetPixel(bitmap.Width - 1, bitmap.Height - 1).R + bitmap.GetPixel(bitmap.Width - 2, bitmap.Height - 1).R + bitmap.GetPixel(bitmap.Width - 1, bitmap.Height - 1).R) / 4;
            green = (bitmap.GetPixel(bitmap.Width - 2, bitmap.Height - 2).G + bitmap.GetPixel(bitmap.Width - 1, bitmap.Height - 1).G + bitmap.GetPixel(bitmap.Width - 2, bitmap.Height - 1).G + bitmap.GetPixel(bitmap.Width - 1, bitmap.Height - 1).G) / 4;
            blue = (bitmap.GetPixel(bitmap.Width - 2, bitmap.Height - 2).B + bitmap.GetPixel(bitmap.Width - 1, bitmap.Height - 1).B + bitmap.GetPixel(bitmap.Width - 2, bitmap.Height - 1).B + bitmap.GetPixel(bitmap.Width - 1, bitmap.Height - 1).B) / 4;
            pixel = Color.FromArgb(red, green, blue);
            newBmp.SetPixel(bitmap.Width - 1, bitmap.Height - 1, pixel);

            //left + right
            for (int i = 1; i < bitmap.Height; i++) {
                pixel = bitmap.GetPixel(0, i);
                newBmp.SetPixel(0, i, pixel);
                pixel = bitmap.GetPixel(bitmap.Width - 1, i);
                newBmp.SetPixel(bitmap.Width - 1, i, pixel);
            }

            //top + botom
            for (int i = 1; i < bitmap.Width; i++) {
                pixel = bitmap.GetPixel(i, 0);
                newBmp.SetPixel(i, 0, pixel);
                pixel = bitmap.GetPixel(i, bitmap.Height - 1);
                newBmp.SetPixel(i, bitmap.Height - 1, pixel);
            }

            //center
            for (int i = 1; i < bitmap.Width - 1; i++) {
                for (int j = 1; j < bitmap.Height - 1; j++) {
                    for (int m = i - 1; m < i + 2; m++) {
                        for (int n = j - 1; n < j + 2; n++) {
                            red += bitmap.GetPixel(m, n).R;
                            green += bitmap.GetPixel(m, n).G;
                            blue += bitmap.GetPixel(m, n).B;
                        }
                    }
                    red /= 9;
                    green /= 9;
                    blue /= 9;
                    pixel = Color.FromArgb(red, green, blue);
                    newBmp.SetPixel(i, j, pixel);
                    red = 0; green = 0; blue = 0;
                }
            }
            newBmp.Save(savePath);
        }
    }
}