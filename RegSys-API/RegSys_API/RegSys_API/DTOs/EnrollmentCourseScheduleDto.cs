using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.DTOs
{
    public class EnrollmentCourseScheduleDto
    {
        public int EnrollmentCourseScheduleId { get; set; }
        public int EnrollmentId { get; set; }
        public EnrollmentDto Enrollment { get; set; }
        public int CourseScheduleId { get; set; }
        public CourseScheduleDto CourseSchedule { get; set; }
    }
}
