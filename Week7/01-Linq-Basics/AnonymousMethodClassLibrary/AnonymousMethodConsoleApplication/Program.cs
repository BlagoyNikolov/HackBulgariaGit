using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnonymousMethodClassLibrary;

namespace AnonymousMethodConsoleApplication {
    class Program {
        static void Main(String[] args) {
            AverageAggregator avgAggregator = new AverageAggregator();
            avgAggregator.AverageChanged += delegate (object sender, EventArgs e) {
                AverageAggregator aggro = (AverageAggregator)sender;
                Console.WriteLine("Average changed New average: " + aggro.Average);
            };

            avgAggregator.AddNumber(2);
            avgAggregator.AddNumber(4);
            avgAggregator.AddNumber(9);
        }
    }
}
