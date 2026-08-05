namespace P02_SalesDatabase.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }

        public DateTime Date { get; set; }

        public Product Product { get; set; } = new();

        public Customer Customer { get; set; } = new();

        public Store Store { get; set; } = new();
    }
}
