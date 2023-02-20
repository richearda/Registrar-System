using AutoMapper;
using AutoMapper.QueryableExtensions;
using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Services.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services
{
    public class TeacherCourseScheduleService : ITeacherCourseScheduleService
    {
        private readonly RegSysDbContext _dbContext;
        private readonly IMapper _mapper;

        public TeacherCourseScheduleService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<TeacherCourseScheduleDto> GetCourseSchedules(int termId, int semesterId)
        {
            return _dbContext.TeacherCourseSchedules.Where(t => t.CourseSchedule.TermId == termId && t.CourseSchedule.SemesterId == semesterId).ProjectTo<TeacherCourseScheduleDto>(_mapper.ConfigurationProvider).ToList();
        }
    }
}