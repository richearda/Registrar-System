namespace ISMS_API.Models
{
    public class PayableTransaction
    {
        public int PayableTransactionId { get; set; }
        public int PayableId { get; set; }
        public int TransactionId { get; set; }
        public Payable Payable { get; set; }
        public Transaction Transaction { get; set; }
    }
}
