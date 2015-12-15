using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BuiltInClasses {
    class Appointments {
        public static void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations) {
            DateTime datetime = new DateTime();
            TimeSpan timespan = new TimeSpan();
            if (startDates.Length == durations.Length) {
                for (int j = 0; j < startDates.Length - 1; j++) {
                    for (int i = 0; i < startDates.Length - 1; i++) {
                        if (startDates[i] > startDates[i + 1]) {
                            datetime = startDates[i];
                            startDates[i] = startDates[i + 1];
                            startDates[i + 1] = datetime;

                            timespan = durations[i];
                            durations[i] = durations[i + 1];
                            durations[i + 1] = timespan;
                        }
                    }
                }

                for (int i = 0; i < startDates.Length; i++) {
                    Console.WriteLine(startDates[i]);
                    Console.WriteLine(durations[i]);
                }

                for (int i = 0; i < startDates.Length - 1; i++) {
                    if (startDates[i] + durations[i] > startDates[i + 1]) {
                        timespan = (startDates[i] + durations[i]) - startDates[i + 1];
                        Console.WriteLine("The appointment starting at {0} intersects the appointment starting at {1} with exactly {2} minutes.", startDates[i], startDates[i + 1], timespan.Minutes);
                    }
                }
            }
        }
    }
}
