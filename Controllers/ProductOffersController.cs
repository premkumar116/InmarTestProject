using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOffersController : ControllerBase
    {
        private readonly OfferService _offerService;
        public ProductOffersController(OfferService OfferService)
        {
            _offerService = OfferService;
        }

        //GET  Todays Offers  
        [HttpGet("GetTodaysOffers")]
        public async Task<IActionResult> GetTodaysOffers()            
        {
            var todaysOffers = await _offerService.GetTodaysOffers();
            return Ok(todaysOffers);
        }
        //GET    Returns 3 Products with lowest price  
        [HttpGet("ThreeLowestPriceProducts")]
        public async Task<IActionResult> GetProductsWithThreeLowestPrice()
        {
            var ProductList = await _offerService.GetAllProducts();
            var productsWithThreeLowestPrice = ProductList.OrderBy(prod => prod.Price).Take(3);
            return Ok(productsWithThreeLowestPrice);
        }
        //GET    Returns Product with 2nd lowest price   
        [HttpGet("GetProductwithSecondLowestPrice")]
        public async Task<IActionResult> GetProductWithSecondLowestPrice()
        {
            var ProductList = await _offerService.GetAllProducts();
            var productWithSecondLowestPrice = ProductList.OrderBy(prod => prod.Price).Skip(1).First();
            return Ok(productWithSecondLowestPrice);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewProduct(Product item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            await _offerService.AddNewProduct(item);
            return Ok(item);
        }

    }
}
