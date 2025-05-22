namespace LAB06.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public double OriginalPrice { get; set; }
        public double SalePrice { get; set; }
        public bool IsFreeShipping { get; set; }
        public string ImageUrl { get; set; }
    }
}
