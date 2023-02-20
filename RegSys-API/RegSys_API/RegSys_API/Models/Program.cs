using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Program
    {
        public Program()
        {
            Curricula = new HashSet<Curriculum>();
            ProgramMajors = new HashSet<ProgramMajor>();
            Students = new HashSet<Student>();
        }

        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramCode { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Curriculum> Curricula { get; set; }
        public virtual ICollection<ProgramMajor> ProgramMajors { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
