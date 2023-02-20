using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
            CurriculumCourses = new HashSet<CurriculumCourse>();
        }

        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public int Units { get; set; }
        public int? NoOfHours { get; set; }
        public int? CourseTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public bool? IsActive { get; set; }

        public virtual CourseType CourseType { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
        public virtual ICollection<CurriculumCourse> CurriculumCourses { get; set; }
    }
}
