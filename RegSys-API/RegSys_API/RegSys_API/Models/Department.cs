using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Department
    {
        public Department()
        {
            CollegeDepartments = new HashSet<CollegeDepartment>();
            Courses = new HashSet<Course>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CollegeDepartment> CollegeDepartments { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}