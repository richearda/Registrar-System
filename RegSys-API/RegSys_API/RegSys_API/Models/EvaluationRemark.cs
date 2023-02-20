using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class EvaluationRemark
    {
        public EvaluationRemark()
        {
            EvaluationItems = new HashSet<EvaluationItem>();
        }

        public int EvaluationItemRemarksId { get; set; }
        public string EvaluationItemRemarksDescription { get; set; }
        public string EvaluationItemRemarksCode { get; set; }
        public int? EvaluationItemRemarksWeight { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<EvaluationItem> EvaluationItems { get; set; }
    }
}
