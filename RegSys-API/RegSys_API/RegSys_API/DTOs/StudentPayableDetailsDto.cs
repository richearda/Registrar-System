namespace ISMS_API.DTOs
{
    public class StudentPayableDetailsDto
    {
        public int PayableId { get; set; }
        public string PayableRef { get; set; }
        public string Fee { get; set; }
        public string FeeType { get; set; }
        public decimal FeeAmount { get; set; }
    }
}