using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.DTOs
{
    public class EnrolleeDto
    {
        public int StudentId { get; set; }
        public string StudentNo { get; set; }
        public int ProgramId { get; set; }
        public int MajorId { get; set; }
        public string Lrnno { get; set; }
        public string FullName { get; set; }
        public string Course { get; set; }
        public string Major { get; set; }
        public string YearLevel { get; set; }
    }
}