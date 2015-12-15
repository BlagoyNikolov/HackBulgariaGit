using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAT_Tax;

namespace ShopInventoryApplication {
    public class Product {
        private double price;
        private double priceWithTax;
        private string country;
        private string name;
        private int quantity;
        private int id;

        public Product(double price, string country, string name, int quantity, int id) {
            this.price = price;
            this.priceWithTax = CalculatePrice(price, country);
            this.country = country;
            this.name = name;
            this.quantity = quantity;
            this.id = id;
        }

        public double Price { get { return price; } }
        public double PriceWithTax { get { return priceWithTax; } }
        public string Country { get { return country; } }
        public string Name { get { return name; } }
        public int Quantity { get { return quantity; } }
        public int Id { get { return id; } }

        public double CalculatePrice(double price, string country) {
            List<CountryVATTAX> list = new List<CountryVATTAX>();
            list.Add(new CountryVATTAX("Bulgaria", 0.2, false));
            list.Add(new CountryVATTAX("Germany", 0.19, false));
            list.Add(new CountryVATTAX("USA", 0.11, false));
            list.Add(new CountryVATTAX("GB", 0.2, false));
            list.Add(new CountryVATTAX("Australia", 0.1, true));
            list.Add(new CountryVATTAX("Italy", 0.22, false));

            VATTAXCalculator calc = new VATTAXCalculator(list);
            return price + calc.CalculateTax(price, country);
        }
    }
}
