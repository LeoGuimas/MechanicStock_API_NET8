using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_StockMechanic.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [StringLength(80)]
        [Required]
        public string? Name { get; set; }

        [Required]
        [StringLength(300)]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(300)]
        public string? ImageUrl {  get; set; }

        public float Stock {  get; set; }

        public DateTime RegisterDate { get; set; }


        //GENERATE FOREIGN KEY
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
