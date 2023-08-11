using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ProductItem> products = new List<ProductItem>
            {
                new ProductItem { title = "Product 1", startCount = 5, oldPrice = 120.00m, price = 100.00m, imageUrl = "../../images/product1.webp", isSale = true },
                new ProductItem { title = "Product 2", startCount = 8, oldPrice = 50.00m, price = 40.00m, imageUrl = "../../images/product2.webp", isSale = false },
                new ProductItem { title = "Product 3", startCount = 10, oldPrice = 80.00m, price = 70.00m, imageUrl = "../../images/product3.webp", isSale = true },
                new ProductItem { title = "Product 4", startCount = 6, oldPrice = 60.00m, price = 50.00m, imageUrl = "../../images/product4.webp", isSale = false },
                new ProductItem { title = "Product 5", startCount = 12, oldPrice = 150.00m, price = 120.00m, imageUrl = "../../images/product5.webp", isSale = true },
                new ProductItem { title = "Product 6", startCount = 3, oldPrice = 30.00m, price = 25.00m, imageUrl = "../../images/product6.webp", isSale = false },
                new ProductItem { title = "Product 7", startCount = 7, oldPrice = 70.00m, price = 60.00m, imageUrl = "../../images/product7.webp", isSale = true },
                new ProductItem { title = "Product 8", startCount = 9, oldPrice = 90.00m, price = 75.00m, imageUrl = "../../images/product8.webp", isSale = false }
            };

            return View(products);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}