using AutoMapper;
using AutoMapper.QueryableExtensions;
using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Services
{
    public class CourseScheduleService : ICourseScheduleService
    {
        private RegSysDbContext _dbContext;
        private IMapper _mapper;

        public CourseScheduleService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IEnumerable<CourseScheduleDto> GetCourseSchedules()
        {
            return _dbContext.CourseSchedules.ProjectTo<CourseScheduleDto>(_mapper.ConfigurationProvider).ToList();
        }

        public IEnumerable<CourseScheduleDto> GetCurrentOfferedSchedules()
        {
            return _dbContext.CourseSchedules.Where(cs => cs.Term.IsActive == true
                    && cs.Term.IsCurrent == true
                    && cs.Semester.IsActive == true
                    && cs.Semester.IsCurrent == true
                    && cs.IsActive == true).ProjectTo<CourseScheduleDto>(_mapper.ConfigurationProvider).ToList();
        }
    }
}