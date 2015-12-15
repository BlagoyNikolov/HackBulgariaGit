using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventoryApplication {
    public class ShopInventory {
        List<Product> inventory = new List<Product>();

        public ShopInventory(List<Product> products) {
            this.inventory = products;
        }

        public double Audit() {
            double revenue = 0;
            foreach (var product in inventory) {
                revenue += product.PriceWithTax * product.Quantity;
            }
            return revenue;
        }

        public double RequestOrder(Order order) {
            double amount = 0;
            for (int i = 0; i < inventory.Count; i++) {
                for (int j = 0; j < order.productID.Count; j++) {
                    if (inventory[i].Id == order.productID[j]) {
                        if (inventory[i].Quantity >= order.productQUANTITY[j]) {
                            amount += inventory[i].PriceWithTax * order.productQUANTITY[j];
                        }
                        else {
                            throw new NotAvailableInInventoryException("The inventory doesn't contain all the required products");
                        }
                    }
                }
            }
            return amount;
        }

        [Serializable]
        private class NotAvailableInInventoryException : Exception {
            public NotAvailableInInventoryException() {
            }

            public NotAvailableInInventoryException(string message) : base(message) {
            }

            public NotAvailableInInventoryException(string message, Exception innerException) : base(message, innerException) {
            }

            protected NotAvailableInInventoryException(SerializationInfo info, StreamingContext context) : base(info, context) {
            }
        }
    }
}