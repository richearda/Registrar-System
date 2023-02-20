using ISMS_API.DTOs;
using System.Collections.Generic;

namespace ISMS_API.Services.Abstract
{
    public interface ITeacherCourseScheduleService
    {
        List<TeacherCourseScheduleDto> GetCourseSchedules(int termId, int semesterId);
    }
}