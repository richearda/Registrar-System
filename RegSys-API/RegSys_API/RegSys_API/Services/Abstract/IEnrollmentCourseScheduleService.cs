using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections.Generic;

namespace ISMS_API.Services.Abstract
{
    public interface IEnrollmentCourseScheduleService
    {
        int AddEnrollmentCourseSchedule(AddEnrollmentCourseSchedulesDto enrollmentCourseSchedDto);

        int UpdateEnrollmentCourseSchedule(EnrollmentCourseSchedule enrollmentCourseSchedule);

        int DeleteEnrollmentCourseSchedule(int ID);

        List<GetEnrollmentCourseScheduleDto> GetEnrollmentCourseSchedule(int ID);

        List<EnrollmentCourseScheduleDto> GetEnrollmentCourseScheduleByStudentId(int ID);

        List<EnrollmentCourseSchedule> GetEnrollmentCourseSchedules();

        List<GetEnrollmentStudentDto> GetStudentInSubject(int termId, int semesterId, int courseSchedId);

        List<GetStudentSubjectListDto> GetStudentSubjectList(int termId, int semesterId, int studentId);
    }
}