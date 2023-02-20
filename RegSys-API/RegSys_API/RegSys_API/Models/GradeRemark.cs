using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class GradeRemark
    {
        public GradeRemark()
        {
            StudentGrades = new HashSet<StudentGrade>();
        }

        public int GradeRemarksId { get; set; }
        public string GradeRemarksDescription { get; set; }
        public string GradeRemarksCode { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<StudentGrade> StudentGrades { get; set; }
    }
}
