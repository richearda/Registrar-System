using System.Collections.Generic;

namespace ISMS_API.DTOs
{
    public class BlockCourseScheduleDto
    {
        public int BlockCourseScheduleId { get; set; }
        public int BlockId { get; set; }
        public int CourseScheduleId { get; set; }
        public BlockDto Block { get; set; }
        public CourseScheduleDto CourseSchedule { get; set; }
    }
}