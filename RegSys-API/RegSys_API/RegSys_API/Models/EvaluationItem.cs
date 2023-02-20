using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class EvaluationItem
    {
        public EvaluationItem()
        {
            EvaluationResponseDetails = new HashSet<EvaluationResponseDetail>();
        }

        public int EvaluationItemId { get; set; }
        public int? EvaluationPart { get; set; }
        public int? EvaluationCriteriaId { get; set; }
        public int? EvaluationItemNo { get; set; }
        public string EvaluationItemDetails { get; set; }
        public bool? IsActive { get; set; }
        public int? EvaluationItemRemarksId { get; set; }

        public virtual EvaluationCriterion EvaluationCriteria { get; set; }
        public virtual EvaluationRemark EvaluationItemRemarks { get; set; }
        public virtual ICollection<EvaluationResponseDetail> EvaluationResponseDetails { get; set; }
    }
}
