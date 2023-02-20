using AutoMapper;
using AutoMapper.QueryableExtensions;
using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Services
{
    public class SemesterService : ISemesterService
    {
        private RegSysDbContext _dbContext;
        private IMapper _mapper;

        public SemesterService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public SemesterDto GetCurrentActiveSemester()
        {
            return _dbContext.Semesters.AsNoTracking().Where(s => s.IsCurrent == true && s.IsActive == true).ProjectTo<SemesterDto>(_mapper.ConfigurationProvider).FirstOrDefault();
        }

        public List<SemesterDto> GetSemesters()
        {
            return _dbContext.Semesters.ProjectTo<SemesterDto>(_mapper.ConfigurationProvider).ToList();
        }
    }
}