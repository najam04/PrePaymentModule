namespace PrePaymentModule.Models
{
    public class Voucher
    {
            public int VoucherId { get; set; } 
            public int VoucherNo { get; set; } 
            public DateTime VoucherDate { get; set; }
            public string VoucherType { get; set; } 
            public string ServiceType { get; set; }
            public string Party { get; set; }
            public string Account { get; set; }
            public string Department { get; set; }
            public string ChequeOrReference { get; set; }
            public decimal Debit { get; set; }
            public decimal Credit { get; set; }
            public string Narration { get; set; }
            public string? VoucherReference { get; set; }
        public int InstallmentCOde { get; set; }


    }
}
