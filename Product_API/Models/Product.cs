using System.ComponentModel.DataAnnotations;

namespace Product_API.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
