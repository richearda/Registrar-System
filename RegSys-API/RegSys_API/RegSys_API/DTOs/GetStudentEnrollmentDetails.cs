using Microsoft.OpenApi.Any;
using System;
using System.Collections.Generic;

namespace ISMS_API.DTOs
{
    public class GetStudentEnrollmentDetails
    {
        public int EnrollmentId { get; set; }
        public string EnrollmentNo { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Term { get; set; }
        public string Semester { get; set; }
        public string StudentId { get; set; }
        public string StudentNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string Major { get; set; }
        public string YearLevel { get; set; }
        public string FullName { get; set; }
        //public List<GetStudentBlockDetails> EnrollmentBlocks { get; set; }
    }
}