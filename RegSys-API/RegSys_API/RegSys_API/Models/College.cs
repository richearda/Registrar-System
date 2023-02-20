using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class College
    {
        public College()
        {
            CollegeDepartments = new HashSet<CollegeDepartment>();
            Teachers = new HashSet<Teacher>();
        }

        public int CollegeId { get; set; }
        public string CollegeName { get; set; }
        public string CollegeCode { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CollegeDepartment> CollegeDepartments { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
