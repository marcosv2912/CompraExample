using System;
using System.Collections.Generic;
using System.Text;

namespace CompraExample.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
