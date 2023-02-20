using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class StudentCourseSchedule
    {
        public StudentCourseSchedule()
        {
            StudentGrades = new HashSet<StudentGrade>();
        }

        public int StudentCourseScheduleId { get; set; }
        public int? StudentId { get; set; }
        public int? CourseScheduleId { get; set; }
        public bool? IsActive { get; set; }

        public virtual CourseSchedule CourseSchedule { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<StudentGrade> StudentGrades { get; set; }
    }
}
