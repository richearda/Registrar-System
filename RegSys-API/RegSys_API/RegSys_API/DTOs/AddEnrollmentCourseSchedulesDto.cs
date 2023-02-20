namespace ISMS_API.DTOs
{
    public class AddEnrollmentCourseSchedulesDto
    {
        public int EnrollmentId { get; set; }
        public int[] CourseScheduleIds { get; set; }
    }
}