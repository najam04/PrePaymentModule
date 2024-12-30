namespace PrePaymentModule.Models
{
    public class Installment
    {
        public int? InstallmentId { get; set; }
        public decimal? OriginalAmount { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? RemainingBalance { get; set; } // To store the remaining balance
        public int InstallmentCOde { get; set; }
        public string? Status { get; set; }
        
    }
}
