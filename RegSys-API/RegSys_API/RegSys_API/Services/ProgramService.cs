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
    public class ProgramService : IProgramService
    {
        private RegSysDbContext _dbContext;
        private IMapper _mapper;

        public ProgramService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public int AddProgram(ISMS_API.Models.Program program)
        {
            _dbContext.Programs.Add(program);
            return _dbContext.SaveChanges();
        }

        public int UpdateProgram(ProgramDto programDto)
        {
            _dbContext.Entry(programDto).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteProgram(int ID)
        {
            ISMS_API.Models.Program toDelete = _dbContext.Programs.Where(s => s.ProgramId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public ISMS_API.Models.Program GetProgram(int ID)
        {
            return _dbContext.Programs.AsNoTracking().Where(s => s.ProgramId == ID).FirstOrDefault();
        }

        public ISMS_API.Models.Program GetProgramByName(string programName)
        {
            return _dbContext.Programs.Where(p => p.ProgramName == programName).FirstOrDefault();
        }

        public IEnumerable<ProgramDto> GetPrograms()
        {
            var programs = _dbContext.Programs.AsNoTracking().Where(s => s.IsActive == true);
            return _mapper.Map<IEnumerable<ProgramDto>>(programs);
        }

        public IEnumerable<ProgramMajorDto> GetProgramMajors(string programName)
        {
            var majors = _dbContext.ProgramMajors.Include(p => p.Major).Where(p => p.Program.ProgramName == programName).ToList();
            return _mapper.Map<IEnumerable<ProgramMajorDto>>(majors);
        }

        public int ActivateProgram(int ID)
        {
            ISMS_API.Models.Program toActivate = _dbContext.Programs.Where(s => s.ProgramId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivateProgram(int ID)
        {
            ISMS_API.Models.Program toDeactivate = _dbContext.Programs.Where(s => s.ProgramId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public bool IsProgramExist(ISMS_API.Models.Program program)
        {
            ISMS_API.Models.Program checkProgram = _dbContext.Programs.Where(s => s.ProgramName == program.ProgramName).FirstOrDefault();
            return (checkProgram != null);
        }
    }
}