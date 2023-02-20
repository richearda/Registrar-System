using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.DTOs
{
    public class GetStudentEnrollmentsDto
    {
        public int EnrollmentId { get; set; }
        public string EnrollmentNo { get; set; }
        public DateTime EnrollmentDate { get; set; }       
        public string Term { get; set; }
        public string Semester { get; set; }
        public bool IsActive { get; set; }
        //public int StudentId { get; set; }
        //public StudentDto Student { get; set; }
        //public string Term { get; set; }
        //public string Semester { get; set; }
    }
}
