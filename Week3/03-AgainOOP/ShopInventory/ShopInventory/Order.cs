using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventoryApplication {
    public class Order {
        private List<int> productId;
        private List<int> productQuantity;

        public Order(List<int> productId, List<int> productQuantity) {
            if (productId.Count == productQuantity.Count) {
                this.productId = productId;
                this.productQuantity = productQuantity;
            }
        }

        public List<int> productID { get { return productId; } }
        public List<int> productQUANTITY { get { return productQuantity; } }

    }
}