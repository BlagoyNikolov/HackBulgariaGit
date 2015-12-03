using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication2.MoreProblems {
    class NOTDONEBoxFilter {
        public static void BlurImage(Bitmap bitmap, string savePath) {

            Bitmap newBmp = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++) {
                for (int j = 0; j < bitmap.Height; j++) {
                    // if(i == 0 && j == 0) {
                    Color pixel = bitmap.GetPixel(i, j);



                    //newBmp.SetPixel(i, j, pixel);
                }
                
                newBmp.Save(savePath);
            }
        }
    }
}