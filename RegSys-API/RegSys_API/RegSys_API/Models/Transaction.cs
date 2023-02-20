using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ISMS_API.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string PayableRefNo { get; set; }
        public string TransactionNo { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime TransactionDate { get; set; }

        public decimal TotalAmountPayable { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal BalancePayable { get; set; }
        public string PaymentStatus { get; set; }
        public int FeeTypeId { get; set; }
        public int TermId { get; set; }
        public int SemesterId { get; set; }
        public int StudentId { get; set; }
        public bool IsCurrent { get; set; }
        public bool IsMain { get; set; }

        public FeeType FeeType { get; set; }
        public ICollection<PayableTransaction> PayableTransaction { get; set; }
    }
}