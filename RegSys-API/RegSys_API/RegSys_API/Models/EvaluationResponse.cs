using System;
using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class EvaluationResponse
    {
        public EvaluationResponse()
        {
            EvaluationResponseDetails = new HashSet<EvaluationResponseDetail>();
        }

        public int EvaluationResponseId { get; set; }
        public int? EvaluatedByPersonId { get; set; }
        public int? EvaluationForPersonId { get; set; }
        public int? TermId { get; set; }
        public int? SemesterId { get; set; }
        public DateTime EvaluationDate { get; set; }

        public virtual Person EvaluatedByPerson { get; set; }
        public virtual Person EvaluationForPerson { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual Term Term { get; set; }
        public virtual ICollection<EvaluationResponseDetail> EvaluationResponseDetails { get; set; }
    }
}
