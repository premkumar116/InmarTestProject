using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product() { }

        public Product(string productName, decimal price , string description)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Description = description;
        }
    }
}
