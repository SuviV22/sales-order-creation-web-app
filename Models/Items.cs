namespace sales_order_creation.Models
{
    public class Items
    {
        public string name { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public int qty { get; set; } = 0;
        public decimal price { get; set; } = 0.00M;
    }
}
