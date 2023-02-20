namespace ISMS_API.DTOs
{
    public class PayableDto
    {
        public string PayableRefNo { get; set; }
        public int[] FeeIds { get; set; }
        public int? TermId { get; set; }
        public int? SemesterId { get; set; }
        public int? StudentId { get; set; }
    }
}