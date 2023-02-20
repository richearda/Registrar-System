using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Major
    {
        public Major()
        {
            Curricula = new HashSet<Curriculum>();
            ProgramMajors = new HashSet<ProgramMajor>();
            Students = new HashSet<Student>();
        }

        public int MajorId { get; set; }
        public string MajorName { get; set; }
        public string MajorCode { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Curriculum> Curricula { get; set; }
        public virtual ICollection<ProgramMajor> ProgramMajors { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
