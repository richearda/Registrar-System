namespace ISMS_API.DTOs
{
    public class GetBlockCoursesDto
    {
        public int BlockCourseScheduleId { get; set; }
        public string BlockName { get; set; }
        public CourseScheduleDto CourseSchedules { get; set; }
    }
}