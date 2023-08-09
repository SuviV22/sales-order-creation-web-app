using System.ComponentModel.DataAnnotations;

namespace sales_order_creation.Models
{
    public class Items
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string orderId { get; set; } = string.Empty;
        [Required]
        public string name { get; set; } = string.Empty;
        [Required]
        public string code { get; set; } = string.Empty;
        [Required]
        public int qty { get; set; } = 0;
        [Required]
        public int price { get; set; } = 0;
    }
}
