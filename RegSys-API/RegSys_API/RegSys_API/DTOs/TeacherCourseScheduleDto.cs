namespace ISMS_API.DTOs
{
    public class TeacherCourseScheduleDto
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public CourseScheduleDto CourseSchedule { get; set; }
    }
}