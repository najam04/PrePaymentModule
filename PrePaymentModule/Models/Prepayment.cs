using System.ComponentModel.DataAnnotations;

namespace PrePaymentModule.Models
{
    public class Prepayment
    {
        [Key] 
        public int Id { get; set; }
        public int InstallmentCOde { get; set; }
        public decimal? OriginalValue { get; set; }
        public DateTime? AcquisitionDate { get; set; }
        public decimal? CurrentValue { get; set; }
        public int? Recognitions { get; set; }
        public string? TimeUnit { get; set; }
        public decimal? DepreciatedAmount { get; set; }
        //public DateTime? FirstRecognitionDate { get; set; }
        public string? DeferredExpenseAccount { get; set; }
        public string? ExpenseAccount { get; set; }
        public string? Voucher { get; set; }
        public string? Result { get; set; }
        public string? VoucherReference { get; set; }
    }
}
