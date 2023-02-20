namespace ISMS_API.DTOs
{
    public class GetEnrollmentStudentDto
    {
        public int EnrollmentCourseScheduleId { get; set; }
        public int EnrollmentId { get; set; }
        public int CourseScheduleId { get; set; }
        public int StudentId { get; set; }
        public string StudentNo { get; set; }
        public string StudentName { get; set; }
        public string YearLevel { get; set; }
        public string Course { get; set; }
        public string Major { get; set; }
    }
}