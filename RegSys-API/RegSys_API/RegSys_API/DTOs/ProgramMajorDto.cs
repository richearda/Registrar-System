using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.DTOs
{
    public class ProgramMajorDto
    {
        public ProgramDto Program { get; set; }
        public MajorDto Major { get; set; }
    }
}
