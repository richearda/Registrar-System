using AutoMapper;
using AutoMapper.QueryableExtensions;
using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using System.Linq;

namespace ISMS_API.Services
{
    public class TeacherService : ITeacherService
    {
        private RegSysDbContext _dbContext;
        private IMapper _mapper;

        public TeacherService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IQueryable<TeacherDto> GetTeachers()
        {
            return _dbContext.Teachers.ProjectTo<TeacherDto>(_mapper.ConfigurationProvider);
        }
    }
}