using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.DTOs
{
    public class AddEnrollmentCoursesDto
    {
        public int EnrollmentId { get; set; }
        public int[] CourseScheduleIds { get; set; }
    }
}
