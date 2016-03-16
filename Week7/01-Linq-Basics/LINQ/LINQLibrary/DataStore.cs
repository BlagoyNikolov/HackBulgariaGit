using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLibrary {
    public class DataStore {
        /* Implement class DataStore which has the following three static methods :
        GetProducts() : returns a list with all products, ProductIds should be between 1 and 100
        GetCategories() : returns a list with all categories, CategoriesIds should be between 101 and 200
        GetOrders() : returns a list with all orders, OrderIds should be between 201 and 300 */

        private List<Product> listofproducts;
        private List<Category> listofcategories;
        private List<Order> listoforders;

        public DataStore() {
            listofproducts = new List<Product>();
            listofcategories = new List<Category>();
            listoforders = new List<Order>();
        }

        public DataStore(List<Product> products , List<Category> categories, List<Order> orders) {
            listofproducts = products;
            listofcategories = categories;
            listoforders = orders;
        }

        public void AddProduct(Product product) {
            listofproducts.Add(product);
        }

        public void AddCategory(Category category) {
            listofcategories.Add(category);
        }

        public void AddProduct(Order order) {
            listoforders.Add(order);
        }

        public List<Product> GetProducts() {
            return listofproducts;
        }

        public List<Category> GetCategories() {
            return listofcategories;
        }

        public List<Order> GetOrders() {
            return listoforders;
        }
    }
}