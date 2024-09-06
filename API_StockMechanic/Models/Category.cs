using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_StockMechanic.Models
{
    [Table("Categories")]
    public class Category
    {
        public Category() { 
        
            Products = new Collection<Product>();
        }

        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        
        [Required]
        [StringLength(300)]
        public string? ImagemUrl { get; set; }


        //GENERATE FOREIGN KEY
        public ICollection<Product>? Products { get; set; }

    }
}
