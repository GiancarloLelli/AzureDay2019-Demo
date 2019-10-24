using AzureDay.Modern.Products.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AzureDay.Modern.Products.Controllers
{
    public class ProductsController : ControllerBase
    {
        public ActionResult Index()
        {
            var products = new ProductList();

            products.Items = new List<string>()
            {
                "Product 05",
                "Product 04",
                "Product 03",
                "Product 02",
                "Product 01",
            };

            return Ok(products);
        }
    }
}
