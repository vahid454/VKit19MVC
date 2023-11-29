namespace Kit19.Models
{
    public class ProductViewModel
    {
        public string ProductName { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public DateTime? MfgDate { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Conjunction { get; set; } = string.Empty; // AND or OR
    }

}
