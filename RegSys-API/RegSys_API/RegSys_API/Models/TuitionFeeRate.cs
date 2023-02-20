#nullable disable

namespace ISMS_API.Models
{
    public partial class TuitionFeeRate
    {
        public int TuitionFeeRateId { get; set; }
        public decimal? TuitionFeeRateAmount { get; set; }
        public int? YearEffectivity { get; set; }
        public bool? IsActive { get; set; }
    }
}
