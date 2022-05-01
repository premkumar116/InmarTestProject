using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class OfferService
    {
        private List<Product> Inventory;
        private void PopulateInventory()
        {

            List<Product> pLists = new List<Product>()
            {
            new Product (){ ProductName = "P1", Price = 1000 , Description = "P1 desc"},
            new Product (){ ProductName = "P2", Price = 200, Description = "P2 desc" },
            new Product (){ ProductName = "P3", Price = 400 , Description = "P3 desc" },
            new Product (){ ProductName = "P4", Price = 700 , Description = "P4 desc" },
            new Product (){ ProductName = "P5", Price = 600 , Description = "P5 desc" },
            new Product (){ ProductName = "P6", Price = 800 , Description = "P6 desc" },
             };

            Inventory = pLists;            
        }
        public OfferService()
        {
          PopulateInventory();
        }
        public Task<List<Product>> GetAllProducts()
        {
            return Task.FromResult(Inventory.ToList());
        }
        public Task<Product> AddNewProduct( Product newProduct)
        {
            Inventory.Add(newProduct);
            return Task.FromResult(newProduct);
        }
        public Task<List<Offer>> GetTodaysOffers()
        {            
         List<Offer> todaysOffers = new List<Offer>()
         {
         new Offer(){ OfferName = "ComboPackage1" , ProductLists = new List <Product>() { new Product() { ProductName = "P2", Price = 200, Description = "P2 desc" }, new Product() { ProductName = "P5", Price = 600, Description = "P5 desc" }, new Product() { ProductName = "P3", Price = 400, Description = "P3 desc" } } },
         new Offer(){ OfferName = "ComboPackage2" , ProductLists = new List <Product>() { new Product() { ProductName = "P4", Price = 200, Description = "P4 desc" }, new Product() { ProductName = "P5", Price = 600, Description = "P5 desc" }, new Product() { ProductName = "P1", Price = 400, Description = "P1 desc" } } },
         new Offer(){ OfferName = "ComboPackage3" , ProductLists = new List <Product>() { new Product() { ProductName = "P2", Price = 200, Description = "P2 desc" }, new Product() { ProductName = "P6", Price = 600, Description = "P6 desc" }, new Product() { ProductName = "P3", Price = 400, Description = "P3 desc" } } },
         new Offer(){ OfferName = "ComboPackage4" , ProductLists = new List <Product>() { new Product() { ProductName = "P1", Price = 200, Description = "P1 desc" }, new Product() { ProductName = "P5", Price = 600, Description = "P5 desc" }, new Product() { ProductName = "P4", Price = 400, Description = "P4 desc" } } }
         };
          return  Task.FromResult(todaysOffers.ToList());
        }
    }
}
