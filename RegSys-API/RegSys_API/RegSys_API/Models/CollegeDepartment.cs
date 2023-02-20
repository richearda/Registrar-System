#nullable disable

namespace ISMS_API.Models
{
    public partial class CollegeDepartment
    {
        public int CollegeDepartmentId { get; set; }
        public int? CollegeId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual College College { get; set; }
        public virtual Department Department { get; set; }
    }
}