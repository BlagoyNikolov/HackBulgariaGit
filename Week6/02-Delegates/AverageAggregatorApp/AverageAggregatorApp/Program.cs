using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAggregatorApp {
    class Program {
        static void Main(String[] args) {
            AverageAggregator avgAggregator = new AverageAggregator();
            avgAggregator.AverageChanged += AvgAggregator_AverageChanged;
            avgAggregator.AddNumber(2);
            avgAggregator.AddNumber(4);
            avgAggregator.AddNumber(9);
        }

        private static void AvgAggregator_AverageChanged(object sender, EventArgs e) {
            Console.WriteLine("Average changed");
            AverageAggregator avg = (AverageAggregator)sender;
            Console.WriteLine("New average: " + avg.Average);
        }
    }
}
