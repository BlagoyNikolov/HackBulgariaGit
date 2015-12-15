using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BuiltInClasses {
    class ClockAngle {
        public static double GetClockHandsAngle(DateTime time, bool exact) {
            if (exact == true) {
                double Hangle = time.Hour * 30;
                if (time.Hour > 12) {
                    Hangle -= 360;
                }
                double mAngle = time.Minute * 6;
                double angle = Math.Abs(Hangle - mAngle);
                return angle;

            }
            else {
                double hAngle = 0.5D * (time.Hour * 60 + time.Minute);
                if (time.Hour > 12) {
                    hAngle -= 360;
                }
                double mAngle = time.Minute * 6;
                double angle = Math.Abs(hAngle - mAngle);
                return angle;
            }
            //angle = Math.Min(angle, 360 - angle);
            //angle = Math.Abs((30 * (time.Hour - (time.Minute / 5))) + (time.Minute / 2));
        }
    }
}
