using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class CourseType
    {
        public CourseType()
        {
            Courses = new HashSet<Course>();
        }

        public int CourseTypeId { get; set; }
        public string CourseTypeName { get; set; }
        public string CourseTypeDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
