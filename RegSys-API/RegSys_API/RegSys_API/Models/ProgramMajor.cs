#nullable disable

namespace ISMS_API.Models
{
    public partial class ProgramMajor
    {
        public int ProgramMajorId { get; set; }
        public int? ProgramId { get; set; }
        public int? MajorId { get; set; }

        public virtual Major Major { get; set; }
        public virtual Program Program { get; set; }
    }
}
