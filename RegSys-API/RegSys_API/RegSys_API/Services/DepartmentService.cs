using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ISMS_API.Services
{
    public class DepartmentService
    {
        private readonly RegSysDbContext _dbContext;

        public DepartmentService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public IEnumerable<ProgramMajorDto> GetProgramMajors(string programName)
        //{
        //    var majors = _dbContext.ProgramMajors.Include(p => p.Major).Where(p => p.Program.ProgramName == programName).ToList();
        //    return _mapper.Map<IEnumerable<ProgramMajorDto>>(majors);
        //}
        //public List<MajorDto> GetDepartmentMajors(int departmentId)
        //{
        //   retu
        //}
    }
}