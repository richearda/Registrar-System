using System;
using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Curriculum
    {
        public Curriculum()
        {
            CurriculumCourses = new HashSet<CurriculumCourse>();
        }

        public int CurriculumId { get; set; }
        public string CurriculumName { get; set; }
        public int? ProgramId { get; set; }
        public int? MajorId { get; set; }
        public DateTime? Effectivity { get; set; }
        public string Cmo { get; set; }
        public int? TermId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Major Major { get; set; }
        public virtual Program Program { get; set; }
        public virtual Term Term { get; set; }
        public virtual ICollection<CurriculumCourse> CurriculumCourses { get; set; }
    }
}
