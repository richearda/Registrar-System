using System.ComponentModel.DataAnnotations;

namespace ISMS_API.Models
{
    public class EnrollmentCourseSchedule
    {
        [Key]
        public int EnrollmentCourseScheduleId { get; set; }

        public int EnrollmentId { get; set; }
        public int CourseScheduleId { get; set; }
        public Enrollment Enrollment { get; set; }
        public CourseSchedule CourseSchedule { get; set; }
    }
}