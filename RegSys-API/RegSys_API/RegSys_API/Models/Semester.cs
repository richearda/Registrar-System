using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Semester
    {
        public Semester()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
            CurriculumCourses = new HashSet<CurriculumCourse>();
            EvaluationResponses = new HashSet<EvaluationResponse>();
            ShsSubjectSchedules = new HashSet<ShsSubjectSchedule>();
        }

        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        public string SemesterCode { get; set; }
        public bool? IsCurrent { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
        public virtual ICollection<CurriculumCourse> CurriculumCourses { get; set; }
        public virtual ICollection<EvaluationResponse> EvaluationResponses { get; set; }
        public virtual ICollection<ShsSubjectSchedule> ShsSubjectSchedules { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
