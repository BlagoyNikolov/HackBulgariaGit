using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQLibrary;

namespace LINQApplication {
    class Program {
        static void Main(string[] args) {
            List<Product> products = new List<Product>() {
                new Product("Core i7 6700K", 10, 1),
                new Product("Samsung 850 EVO", 30, 5),
                new Product("Core i5 6600K", 11, 1),
                new Product("Gigabyte G1 Sniper", 40, 3),
                new Product("Gigabyte GTX960 Windforce", 50, 2),
                new Product("Corsair CX600M", 70, 7),
                new Product("CoolerMaster VS550", 71, 7),
                new Product("Corsair Vengeance DDR4 2333MHz", 60, 4),
                new Product("Western Digital Black 1TB", 10, 6),
                new Product("Seagate Barracuda 2TB", 11, 6)
            };

            List<Category> categories = new List<Category>()
            {
                new Category(1, "Processors"),
                new Category(2, "Graphics Cards"),
                new Category(3, "Motherboards"),
                new Category(4, "RAM"),
                new Category(5, "SSD"),
                new Category(6, "HDD"),
                new Category(7, "PSU")
            };

            List<Order> orders = new List<Order>()
            {
                new Order(201, new List<int>() {10, 40, 60}, new DateTime(2016, 01, 20, 7, 30, 00), "Order 1"),
                new Order(240, new List<int>() {10, 70, 20 }, new DateTime(2016, 01, 21, 8, 00, 00), "Order 2"),
                new Order(263, new List<int>() {71, 50, 60 }, new DateTime(2016, 01, 24, 9, 20, 00), "Order 3"),
                new Order(290, new List<int>() {60, 11, 30 }, new DateTime(2016, 01, 25, 10, 30, 00), "Order 4"),
                new Order(220, new List<int>() {11, 40, 30 }, new DateTime(2016, 01, 26, 10, 00, 00), "Order 5")
            };

            DataStore store = new DataStore(products, categories, orders);

            /* Create a linq query which returns all products with ids between 15 and 30 */
            var firstQuerry = from product in store.GetProducts()
                              where product.ProductId >= 15 && product.ProductId <= 30
                              select product;

            /* Create a linq query which returns all categories with ids between 105 and 125 */
            var secondQuerry = from category in store.GetCategories()
                               where category.CategoryId >= 105 && category.CategoryId <= 125
                               select category;

            /* Create a linq query which returns first 15 orders sorted by order name */
            var thirdQuerry = (from order in store.GetOrders()
                               orderby order.Name
                               select order).Take(15);

            /* Create linq query which returns first 3 orders which contains a specific productId (e.g. 10). 
            Orders must be sorted based on OrderDate The print order names. */
            var fourthQuerry = (from order in store.GetOrders()
                               where order.Products.Contains(10)
                               orderby order.OrderDate
                               select order.OrderDate).Take(3);

            /* Create linq query which returns all product with the name of the category which they belong to. 
            Order the result based on CategoryName The result must be printed to the console. */
            var fifthQuerry = from category in store.GetCategories()
                              join product in store.GetProducts() on category.CategoryId equals product.CategoryId
                              orderby category.CategoryName
                              select new { ProductName = product.Name, CategoryName = category.CategoryName };

            foreach (var item in fifthQuerry) {
                Console.Write($"{item.ProductName} - {item.CategoryName}");
                Console.WriteLine();
            }

            /* Create linq query which returns all categories together with their products */
            var sixthQuerry = from category in store.GetCategories()
                              join product in store.GetProducts() on category.CategoryId equals product.CategoryId into productsGroup
                              let productNames = (from prod in productsGroup
                                                  select prod.Name)
                              select new { CategoryName = category.CategoryName, ProductNames = productNames.ToList() };

            /* Create linq query which selects all orders together with their products and then print it to the screen. */
            var seventhQuery = from order in store.GetOrders()
                               let productsList = (from productId in order.Products
                                                   join product in store.GetProducts() on productId equals product.ProductId
                                                   join category in store.GetCategories() on product.CategoryId equals category.CategoryId
                                                   select new { ProductName = product.Name, CategoryName = category.CategoryName })
                               orderby order.OrderDate
                               select new {
                                   OrderName = order.Name,
                                   OrderDate = order.OrderDate,
                                   ProductsWithCategory = productsList
                               };


            foreach (var item in seventhQuery) {
                Console.Write($"{item.OrderName} - {item.OrderDate}");
                foreach (var product in item.ProductsWithCategory) {
                    Console.Write($" {product.ProductName} - {product.CategoryName}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
