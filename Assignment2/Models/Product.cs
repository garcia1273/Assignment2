using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Product
    {
        [Key]
        public string itemName { get; set; }
        public string description { get; set; }
        [Required]
        public int quantity { get; set; }
    }
}