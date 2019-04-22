namespace StorageApp.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
