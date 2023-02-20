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
    public class TermService : ITermService
    {
        private RegSysDbContext _dbContext;
        private IMapper _mapper;

        public TermService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public TermDto GetCurrentActiveTerm()
        {
            return _dbContext.Terms.AsNoTracking().Where(t => t.IsCurrent == true && t.IsActive == true).ProjectTo<TermDto>(_mapper.ConfigurationProvider).FirstOrDefault();
        }

        public Term GetTermByName(string termName)
        {
            return _dbContext.Terms.Where(t => t.TermName == termName).FirstOrDefault();
        }

        public List<TermDto> GetTerms()
        {
            return _dbContext.Terms.ProjectTo<TermDto>(_mapper.ConfigurationProvider).ToList();
        }
    }
}