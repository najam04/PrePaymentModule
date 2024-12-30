namespace PrePaymentModule.Models
{
    public class History
    {
        public int? HistoryId { get; set; }          
        public decimal? OriginalAmount { get; set; } 
        public decimal? Amount { get; set; }          
        public DateTime? DueDate { get; set; }       
        public decimal? RemainingBalance { get; set; } 
        public int InstallmentCode { get; set; }    
        public string? Status { get; set; }           
    }
}
