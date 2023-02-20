using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.DTOs
{
    public class SemesterDto
    {
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
        public string SemesterCode { get; set; }
        public bool? IsCurrent { get; set; }
        public bool? IsActive { get; set; }
    }
}
