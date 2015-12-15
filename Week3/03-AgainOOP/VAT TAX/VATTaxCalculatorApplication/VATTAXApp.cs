using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAT_Tax;

namespace VATTaxCalculatorApplication {
    class VATTAXApp {
        static void Main(string[] args) {
            List<CountryVATTAX> list = new List<CountryVATTAX>();
            list.Add(new CountryVATTAX("Bulgaria", 0.2, false));
            list.Add(new CountryVATTAX("Germany", 0.19, false));
            list.Add(new CountryVATTAX("USA", 0.11, false));
            list.Add(new CountryVATTAX("GB", 0.2, false));
            list.Add(new CountryVATTAX("Australia", 0.1, true));
            list.Add(new CountryVATTAX("Italy", 0.22, false));

            VATTAXCalculator calc = new VATTAXCalculator(list);

            string country, price;
            Console.WriteLine("List of Countries supported:");
            foreach (var item in list) {
                Console.WriteLine(item.CountryId);
            }

            Console.WriteLine("Enter country:");
            country = Console.ReadLine();
            Console.WriteLine("Enter price:");
            price = Console.ReadLine();

            Console.WriteLine("Country: {0}, VAT Tax: {1}$" , country, calc.CalculateTax(Int32.Parse(price), country));
            Console.WriteLine("Default test: {0}", calc.CalculateTax(Int32.Parse(price)));
        }
    }
}
