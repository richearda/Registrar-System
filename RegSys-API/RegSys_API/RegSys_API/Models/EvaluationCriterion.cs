using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class EvaluationCriterion
    {
        public EvaluationCriterion()
        {
            EvaluationItems = new HashSet<EvaluationItem>();
        }

        public int EvaluationCriteriaId { get; set; }
        public string EvaluationCriteriaDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<EvaluationItem> EvaluationItems { get; set; }
    }
}
