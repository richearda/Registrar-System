using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class ShsSubject
    {
        public ShsSubject()
        {
            ShsSubjectSchedules = new HashSet<ShsSubjectSchedule>();
        }

        public int SubjectId { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectDescription { get; set; }
        public int? StrandId { get; set; }
        public string GradeLevel { get; set; }

        public virtual Strand Strand { get; set; }
        public virtual ICollection<ShsSubjectSchedule> ShsSubjectSchedules { get; set; }
    }
}
