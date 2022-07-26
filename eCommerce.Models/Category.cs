using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public List<Product> Products { get; set; }
    }
}
