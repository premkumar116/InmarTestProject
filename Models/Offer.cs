using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Offer
    {
        public string OfferName { get; set; }
        public List<Product> ProductLists { get; set; }

        public Offer() { }

        public Offer(string offerName ,List<Product>products)
        {
            this.OfferName = offerName;
            this.ProductLists = products;
        }
    }
}
