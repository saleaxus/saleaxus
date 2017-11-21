using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Saleaxus.Entity
{
    public class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Product(decimal price, string name)
        {
            this.Price = price;
            this.Name = name;
        }
    }
}