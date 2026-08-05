namespace P02_SalesDatabase.Models
{
    internal class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
