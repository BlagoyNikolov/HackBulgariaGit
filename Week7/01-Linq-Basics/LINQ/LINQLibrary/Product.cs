using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLibrary {
    public class Product {
        //Name : string, ProductId : int, CategoryId : int
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public Product(string name, int productId, int categoryId) {
            Name = name;
            ProductId = productId;
            CategoryId = categoryId;
        }
    }
}
