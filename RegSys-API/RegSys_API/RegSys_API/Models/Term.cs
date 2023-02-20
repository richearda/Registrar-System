using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Term
    {
        public Term()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
            Curricula = new HashSet<Curriculum>();
            EvaluationResponses = new HashSet<EvaluationResponse>();
        }

        public int TermId { get; set; }
        public string TermName { get; set; }
        public string TermCode { get; set; }
        public bool? IsCurrent { get; set; }
        public bool? IsActive { get; set; }
        //public int EnrollmentId { get; set; }

        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
        public virtual ICollection<Curriculum> Curricula { get; set; }
        public virtual ICollection<EvaluationResponse> EvaluationResponses { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
