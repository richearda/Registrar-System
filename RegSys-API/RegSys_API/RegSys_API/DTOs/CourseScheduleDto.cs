using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.DTOs
{
    public class CourseScheduleDto
    {
        public int CourseScheduleId { get; set; }
        public string Edpcode { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public int Units { get; set; }
        public string Day { get; set; }
        public string TimeStart { get; set; }
        public string MidDayTimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string MidDayTimeEnd { get; set; }
        public string Room { get; set; }
        //public int? TermId { get; set; }
        //public int? SemesterId { get; set; }
        //public int EnrollmentCourseScheduleId { get; set; }
        //public bool? IsActive { get; set; }
    }
}
