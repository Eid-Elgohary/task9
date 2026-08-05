namespace P02_SalesDatabase.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string CreditCArdNumber { get; set; } = string.Empty;

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();



    }
}
