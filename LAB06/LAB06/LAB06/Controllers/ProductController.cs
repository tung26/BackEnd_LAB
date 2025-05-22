using LAB06.Models;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace LAB06.Controllers
{
    public class ProductController : Controller
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category { Id = 1, Name = "Laptop" },
            new Category { Id = 2, Name = "Smartphone" },
            new Category { Id = 3, Name = "Tablet" },
            new Category { Id = 4, Name = "Smartwatch" },
            new Category { Id = 5, Name = "TV" },
            new Category { Id = 6, Name = "Headphones" },
            new Category { Id = 7, Name = "Monitor" },
            new Category { Id = 8, Name = "Gaming Console" },
            new Category { Id = 9, Name = "Keyboard & Mouse" },
            new Category { Id = 10, Name = "Graphics Card" },
            new Category { Id = 11, Name = "RAM & Storage" },
            new Category { Id = 12, Name = "Motherboard" },
            new Category { Id = 13, Name = "Gaming Monitor" },
            new Category { Id = 14, Name = "External Storage" }
        };
        public static List<Brand> brands = new List<Brand>()
        {
            new Brand { Id = 1, Name = "Apple" },
            new Brand { Id = 2, Name = "Samsung" },
            new Brand { Id = 3, Name = "Sony" },
            new Brand { Id = 4, Name = "LG" },
            new Brand { Id = 5, Name = "Dell" },
            new Brand { Id = 6, Name = "HP" },
            new Brand { Id = 7, Name = "Microsoft" },
            new Brand { Id = 8, Name = "Google" },
            new Brand { Id = 9, Name = "Amazon" },
            new Brand { Id = 10, Name = "Lenovo" },
            new Brand { Id = 11, Name = "Logitech" },
            new Brand { Id = 12, Name = "Razer" },
            new Brand { Id = 13, Name = "NVIDIA" },
            new Brand { Id = 14, Name = "Corsair" },
            new Brand { Id = 15, Name = "Asus" },
            new Brand { Id = 16, Name = "GoPro" },
            new Brand { Id = 17, Name = "DJI" },
            new Brand { Id = 18, Name = "HyperX" }
        };
        public static List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Apple MacBook Pro 14", Description =
            "Powerful laptop with M2 chip.", Category = "Laptop", Brand = "Apple", OriginalPrice =
            2199.99, SalePrice = 1999.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 2, Name = "Samsung Galaxy S24 Ultra",
            Description = "High-end flagship smartphone.", Category = "Smartphone", Brand =
            "Samsung", OriginalPrice = 1399.99, SalePrice = 1299.99, IsFreeShipping = true,
            ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 3, Name = "Sony WH-1000XM5", Description =
            "Noise-canceling wireless headphones.", Category = "Headphones", Brand = "Sony",
            OriginalPrice = 399.99, SalePrice = 349.99, IsFreeShipping = false, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 4, Name = "LG OLED C2 55 inch", Description =
            "Premium OLED TV with 4K resolution.", Category = "TV", Brand = "LG", OriginalPrice =
            1599.99, SalePrice = 1499.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 5, Name = "Dell XPS 15", Description = "Highperformance laptop with OLED display.", Category = "Laptop", Brand = "Dell",
            OriginalPrice = 1899.99, SalePrice = 1799.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 6, Name = "HP Spectre x360", Description =
            "Convertible laptop with touch screen.", Category = "Laptop", Brand = "HP",
            OriginalPrice = 1699.99, SalePrice = 1599.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 7, Name = "Apple iPad Pro 12.9", Description =
            "Powerful tablet with M2 chip.", Category = "Tablet", Brand = "Microsoft",
            OriginalPrice = 1199.99, SalePrice = 1099.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 8, Name = "Samsung Galaxy Tab S8", Description =
            "High-end Android tablet.", Category = "Tablet", Brand = "Samsung", OriginalPrice =
            899.99, SalePrice = 799.99, IsFreeShipping = false, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 9, Name = "Apple Watch Series 8", Description =
            "Smartwatch with fitness tracking.", Category = "Smartwatch", Brand = "Apple",
            OriginalPrice = 499.99, SalePrice = 449.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 10, Name = "Sony PlayStation 5", Description =
            "Next-gen gaming console.", Category = "Gaming Console", Brand = "Sony", OriginalPrice
            = 499.99, SalePrice = 479.99, IsFreeShipping = false, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 11, Name = "Microsoft Surface Laptop 5",
            Description = "Slim and powerful touchscreen laptop.", Category = "Laptop", Brand =
            "Microsoft", OriginalPrice = 1299.99, SalePrice = 1199.99, IsFreeShipping = true,
            ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 12, Name = "Google Pixel 7 Pro", Description =
            "Google's flagship Android smartphone.", Category = "Smartphone", Brand = "Google",
            OriginalPrice = 899.99, SalePrice = 849.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 13, Name = "Bose QuietComfort Earbuds II",
            Description = "Premium noise-canceling earbuds.", Category = "Headphones", Brand =
            "Amazon", OriginalPrice = 299.99, SalePrice = 279.99, IsFreeShipping = false, ImageUrl
            = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 14, Name = "Samsung Neo QLED 75 inch",
            Description = "Advanced 4K Smart TV with Neo QLED.", Category = "TV", Brand =
            "Samsung", OriginalPrice = 2999.99, SalePrice = 2799.99, IsFreeShipping = true,
            ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 15, Name = "Canon EOS R6", Description = "Fullframe mirrorless camera for professionals.", Category = "Monitor", Brand = "Lenovo",
            OriginalPrice = 2499.99, SalePrice = 2299.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 16, Name = "Logitech MX Master 3S", Description
            = "Advanced wireless mouse for professionals.", Category = "Keyboard & Mouse", Brand =
            "Logitech", OriginalPrice = 99.99, SalePrice = 89.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 17, Name = "Razer BlackWidow V4 Pro",
            Description = "High-end mechanical gaming keyboard.", Category = "Keyboard & Mouse",
            Brand = "Razer", OriginalPrice = 229.99, SalePrice = 199.99, IsFreeShipping = false,
            ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 18, Name = "NVIDIA GeForce RTX 4090",
            Description = "Cutting-edge gaming graphics card.", Category = "Graphics Card", Brand =
            "NVIDIA", OriginalPrice = 1599.99, SalePrice = 1499.99, IsFreeShipping = true, ImageUrl
            = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 19, Name = "Corsair Vengeance DDR5 32GB",
            Description = "High-performance RAM for gaming PCs.", Category = "RAM & Storage", Brand
            = "Corsair", OriginalPrice = 299.99, SalePrice = 279.99, IsFreeShipping = true,
            ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 20, Name = "Asus ROG Strix X670E", Description =
            "Premium motherboard for gaming setups.", Category = "Motherboard", Brand = "Asus",
            OriginalPrice = 499.99, SalePrice = 459.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 21, Name = "GoPro Hero 11 Black", Description =
            "Rugged action camera for adventures.", Category = "Monitor", Brand = "GoPro",
            OriginalPrice = 499.99, SalePrice = 449.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 22, Name = "DJI Mini 3 Pro", Description =
            "Compact and powerful drone with 4K camera.", Category = "Monitor", Brand = "DJI",
            OriginalPrice = 899.99, SalePrice = 849.99, IsFreeShipping = true, ImageUrl =
            "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 23, Name = "LG UltraGear 34GP83A-B", Description
            = "Ultra-wide gaming monitor with 144Hz refresh rate.", Category = "Gaming Monitor",
            Brand = "LG", OriginalPrice = 699.99, SalePrice = 649.99, IsFreeShipping = true,
            ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 24, Name = "Samsung T7 Shield 2TB", Description
            = "Portable SSD with high-speed transfer rates.", Category = "External Storage", Brand
            = "Samsung", OriginalPrice = 199.99, SalePrice = 179.99, IsFreeShipping = true,
            ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" },
            new Product { Id = 25, Name = "HyperX Cloud Alpha Wireless",
            Description = "Premium wireless gaming headset.", Category = "Headphones", Brand =
            "HyperX", OriginalPrice = 199.99, SalePrice = 179.99, IsFreeShipping = false, ImageUrl
            = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp14-spacegray-select-202301?wid=2000&hei=2000&fmt=jpeg&qlt=90" }
        };
        public IActionResult Index()
        {
            Tuple<List<Category>, List<Brand>, List<Product>> tuple = new
            Tuple<List<Category>, List<Brand>, List<Product>>(categories, brands, products);
            return View(tuple);
        }
        [HttpGet]
        public IActionResult Filters(string searchValue, string brands, string category, double? minPrice, double? maxPrice, bool isFreeShip = false)
        {
            Console.WriteLine(minPrice + ' ' + maxPrice);
            var result = products.AsQueryable();
            if (searchValue != null)
            {
                result = result.Where(p =>
                p.Name.ToLower().Contains(searchValue.ToLower()));
            }
            if (category != null)
            {
                result = result.Where(p => p.Category == category);
            }
            if (brands != null && brands.Length > 0)
            {
                var brandList = brands.Split(',');
                result = result.Where(p => brandList.Contains(p.Brand));
            }
            if (minPrice.HasValue)
            {
                result = result.Where(p => p.SalePrice >= minPrice);
            }
            if (maxPrice.HasValue)
            {
                result = result.Where(p => p.SalePrice <= maxPrice);
            }
            if (isFreeShip)
            {
                Console.WriteLine(1);
                result = result.Where(p => p.IsFreeShipping == true);
            }
            return Ok(result.ToList());
        }
    }
}
