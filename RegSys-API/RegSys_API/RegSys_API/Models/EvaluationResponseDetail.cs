#nullable disable

namespace ISMS_API.Models
{
    public partial class EvaluationResponseDetail
    {
        public int EvaluationResponseDetailsId { get; set; }
        public int? EvaluationResponseId { get; set; }
        public int? EvaluationItemId { get; set; }
        public int? EvaluationRating { get; set; }

        public virtual EvaluationItem EvaluationItem { get; set; }
        public virtual EvaluationResponse EvaluationResponse { get; set; }
    }
}
