namespace MvcEticaret.Models
{
    public class ProductItem
    {
        public string title { get; set; }
        public int startCount { get; set; }
        public decimal oldPrice { get; set; }
        public decimal price { get; set; }
        public string imageUrl { get; set; }
        public bool isSale { get; set; }
    }
}
