using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensionLibrary {
    public class Configuration {
        public char GetReplacingValue() {
            int result = 0;
            DateTime dateTime = DateTime.Now;
            result += Calculate(dateTime.Day);
            result += Calculate(dateTime.Month);
            result += Calculate(dateTime.Year);
            result += Calculate(dateTime.Hour);
            result += Calculate(dateTime.Minute);
            result += Calculate(dateTime.Second);
            result %= 25;
            result += 65;
            //Console.WriteLine("Replacing value is: " + (char)result);
            return (char)result;
        }

        public int Calculate(int number) {
            int sum = 0;
            while (number != 0) {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
