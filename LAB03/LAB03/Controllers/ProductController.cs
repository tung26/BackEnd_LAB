using LAB03.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB03.Controllers
{
    public class ProductController : Controller
    {

        static List<Product> pros = new List<Product>()
        {
            new Product() { Id = 1, Name = "Quần", Price = 190.098},
            new Product() { Id = 2, Name = "Áo", Price = 100.098},
            new Product() { Id = 3, Name = "Tất", Price = 10.098}
        };
        public IActionResult Index()
        {
            return View(pros);
        }

        public IActionResult Detail()
        {
            int id = int.Parse(Request.Query["q"]);
            Product product = new Product();
            foreach (var p in pros)
            {
                if(p.Id == id)
                {
                    product = p;
                    p.ToString();
                    break;
                }
            }
            return View(product);
        }
    }
}
