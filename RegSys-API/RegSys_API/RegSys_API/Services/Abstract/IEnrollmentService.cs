using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IEnrollmentService
    {
        IQueryable<Enrollment> GetEnrollments();

        Enrollment GetCurrentEnrollment(int studentId, int termId, int semesterId);

        int AddEnrollment(EnrollmentDto enrollment);

        int UpdateEnrollment(Enrollment enrollment);

        int ActivateEnrollment(int enrollmentId);

        int DeactivateEnrollment(int enrollmentId);

        int DeleteEnrollment(int id);

        bool IsEnrollmentExist(Enrollment enrollment);

        Enrollment GetEnrollment(int enrollmentId);

        // List<EnrollmentCoursesDto> GetEnrollmentCourses(int enrollmentId);
        IEnumerable<CourseScheduleDto> GetNotEnrolledCourseSchedules(int[] enrolledCourseIds);

        List<GetStudentEnrollmentDetails> GetEnrollmentDto(int programId, int majorId, int termId, int semesterId);
    }
}