namespace Kit19.Model
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public int? Size { get; set; }
        public decimal? Price { get; set; }
        public DateTime? MfgDate { get; set; }
        public string Category { get; set; }
        public string Conjunction { get; set; } // AND or OR
    }

}
