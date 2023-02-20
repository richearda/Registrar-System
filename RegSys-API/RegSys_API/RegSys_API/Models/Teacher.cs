using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            TeacherCourseSchedules = new HashSet<TeacherCourseSchedule>();
            TeacherShsSubjectSchedules = new HashSet<TeacherShsSubjectSchedule>();
        }

        public int TeacherId { get; set; }
        public int? CollegeId { get; set; }
        public bool? IsActive { get; set; }
        public int? PersonId { get; set; }

        public virtual College College { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<TeacherCourseSchedule> TeacherCourseSchedules { get; set; }
        public virtual ICollection<TeacherShsSubjectSchedule> TeacherShsSubjectSchedules { get; set; }
    }
}
