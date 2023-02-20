#nullable disable

namespace ISMS_API.Models
{
    public partial class Fee
    {
        public int FeeId { get; set; }
        public string FeeName { get; set; }
        public string FeeDescription { get; set; }
        public int? FeeTypeId { get; set; }
        public decimal? FeeAmount { get; set; }
        public bool? IsActive { get; set; }
        public virtual FeeType FeeType { get; set; }
    }
}