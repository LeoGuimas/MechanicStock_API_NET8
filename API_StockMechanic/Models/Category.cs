using System.Collections.ObjectModel;

namespace API_StockMechanic.Models
{
    public class Category
    {
        public Category() { 
        
            Products = new Collection<Product>();
        }
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? ImagemUrl { get; set; }

        public ICollection<Product>? Products { get; set; }

    }
}
