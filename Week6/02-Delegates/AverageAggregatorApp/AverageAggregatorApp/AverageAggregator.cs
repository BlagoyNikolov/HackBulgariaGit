using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAggregatorApp {
    class AverageAggregator {
        public event EventHandler AverageChanged;
        public List<int> numbers = new List<int>();
        public double Average { get; set; } = 0;

        public double GetCurrentAverage() {
            double avg = 0;
            foreach (var item in numbers) {
                avg = avg + item;
            }
            return avg / numbers.Count;
        }

        public void AddNumber(int number) {
            numbers.Add(number);
            double newAvg = GetCurrentAverage();
            if (Average != newAvg) {
                Average = newAvg;
                if (AverageChanged != null) {
                    AverageChanged(this, new EventArgs());
                }
            }
        }
    }
}
