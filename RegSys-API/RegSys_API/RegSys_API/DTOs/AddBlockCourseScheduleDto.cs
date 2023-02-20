using System;

namespace ISMS_API.DTOs
{
    public class AddBlockCourseScheduleDto
    {
        public int BlockId { get; set; }
        public int[] CourseScheduleIds { get; set; }
    }
}
