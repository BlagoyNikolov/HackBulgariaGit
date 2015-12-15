using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventoryApplication {
    class ShopInventoryApp {
        static void Main(string[] args) {
            List<Product> products = new List<Product>();
            products.Add(new Product(750, "Bulgaria", "Nexus 5x", 3, 1));
            products.Add(new Product(1000, "USA", "Lenovo B50", 5, 2));
            products.Add(new Product(1250, "Italy", "Sony A50", 8, 3));
            products.Add(new Product(3750, "GB", "BMW 320i", 13, 4));
            products.Add(new Product(250, "Germany", "Motorola Moto360", 23, 5));

            ShopInventory shop = new ShopInventory(products);
            Console.WriteLine("MAX Audit: {0}$", shop.Audit());

            List<int> id = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> quantity = new List<int>() { 3, 5, 7, 11, 20 };

            Order order = new Order(id, quantity);
            Console.WriteLine("TOTAL Order amount: {0}$", shop.RequestOrder(order));

        }
    }
}
