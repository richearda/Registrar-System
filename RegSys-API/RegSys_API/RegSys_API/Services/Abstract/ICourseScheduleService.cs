using ISMS_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Services.Abstract
{
    public interface ICourseScheduleService
    {
        IEnumerable<CourseScheduleDto> GetCourseSchedules();

        IEnumerable<CourseScheduleDto> GetCurrentOfferedSchedules();

        //List<CourseScheduleDto> GetCourseScheduleByProgramAndMajor(int programId, int majorID);
    }
}