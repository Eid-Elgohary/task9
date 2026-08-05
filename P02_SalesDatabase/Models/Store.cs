namespace P02_SalesDatabase.Models
{
    internal class Store
    {
        public int StoreId { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

    }
}
