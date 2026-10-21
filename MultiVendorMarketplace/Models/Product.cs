using System.ComponentModel.DataAnnotations;

namespace MultiVendorMarketplace.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Range(1, Double.MaxValue, ErrorMessage = "Price most be more than 0")]
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
