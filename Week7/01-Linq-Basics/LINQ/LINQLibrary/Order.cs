using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLibrary {
    public class Order {
        // OrderId : int, Products : List<int>, OrderDate : DateTime, Name : string
        public int OrderId { get; set; }
        public List<int> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public string Name { get; set; }

        public Order(int orderId, List<int> products, DateTime orderDate, string name) {
            OrderId = orderId;
            Products = products;
            OrderDate = orderDate;
            Name = name;
        }
    }
}
