using ISMS_API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Services.Abstract
{
    public interface IProgramService
    {
        int AddProgram(ISMS_API.Models.Program program);

        int UpdateProgram(ProgramDto programDto);

        int DeleteProgram(int programID);

        IEnumerable<ProgramDto> GetPrograms();

        IEnumerable<ProgramMajorDto> GetProgramMajors(string programName);

        ISMS_API.Models.Program GetProgram(int programID);

        ISMS_API.Models.Program GetProgramByName(string programName);

        bool IsProgramExist(ISMS_API.Models.Program program);
    }
}