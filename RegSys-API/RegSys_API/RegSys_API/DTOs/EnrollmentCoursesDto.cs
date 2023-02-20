using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.DTOs
{
    public class EnrollmentCoursesDto
    {
        public int EnrollmentCourseScheduleId { get; set; }       
        public CourseScheduleDto CourseSchedule { get; set; }
    }
}
