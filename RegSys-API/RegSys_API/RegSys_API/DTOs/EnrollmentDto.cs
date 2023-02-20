using ISMS_API.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.DTOs
{
    public class EnrollmentDto
    {
        public int EnrollmentId { get; set; }
        public string EnrollmentNo { get; set; }

        public DateTime EnrollmentDate { get; set; }
        public bool IsActive { get; set; }

        public int StudentId { get; set; }
        public int TermId { get; set; }
        public string Term { get; set; }

        public int SemesterId { get; set; }
        public string Semester { get; set; }
        public StudentDto Student { get; set; }
        //public ICollection<EnrollmentBlockDto> EnrollmentBlocks { get; set; }
        //public string Term { get; set; }
        //public string Semester { get; set; }
        //public ICollection<CourseScheduleDto> CourseSchedules { get; set; }
    }
}