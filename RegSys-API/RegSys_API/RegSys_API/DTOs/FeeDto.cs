namespace ISMS_API.DTOs
{
    public class FeeDto
    {
        public int FeeId { get; set; }
        public string FeeName { get; set; }
        public string FeeDescription { get; set; }
        public int FeeTypeId { get; set; }
        public string FeeTypeDescription { get; set; }
        public decimal? FeeAmount { get; set; }
        public bool? IsActive { get; set; }


    }
}
