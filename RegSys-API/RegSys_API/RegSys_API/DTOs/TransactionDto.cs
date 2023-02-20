using System;

namespace ISMS_API.DTOs
{
    public class TransactionDto
    {
        public int TransactionId { get; set; }
        public string PayableRefNo { get; set; }
        public string TransactionNo { get; set; }
        public decimal TotalAmountPayable { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal BalancePayable { get; set; }
        public string PaymentStatus { get; set; }
        public int FeeTypeId { get; set; }
        public string FeeTypeFeeTypeDescription { get; set; }
        public int TermId { get; set; }
        public int SemesterId { get; set; }
        public int StudentId { get; set; }
        public bool IsCurrent { get; set; }
        public bool IsMain { get; set; }
    }
}
