namespace PrePaymentModule.Models
{
    public class VoucherData
    {
        public int VoucherNo { get; set; }
        public string VoucherDate { get; set; }
        public string VoucherType { get; set; }
        public string ServiceType { get; set; }
        public string Account { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string Narration { get; set; }
        public int InstallmentCOde { get; set; }
        public string? VoucherReference { get; set; }
    }
}
