using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CompraExample.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public OrderItem(int quantity, double price, Product product) : this(quantity, price)
        {
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name + ", "
                   + "$" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", "
                   + "Quantidade: " + Quantity + ", "
                   + "Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
