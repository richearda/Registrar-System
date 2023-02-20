namespace ISMS_API.DTOs
{
    public class GetStudentSubjectListDto
    {
        public int EnrollmentCourseScheduleId { get; set; }
        public int EnrollmentId { get; set; }
        public int CourseScheduleId { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public string Units { get; set; }
    }
}