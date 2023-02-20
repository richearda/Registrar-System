using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ISMS_API.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        public string EnrollmentNo { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool IsActive { get; set; }
        public int StudentId { get; set; }
        public int TermId { get; set; }
        public int SemesterId { get; set; }
        public Student Student { get; set; }
        public Term Term { get; set; }
        public Semester Semester { get; set; }
        public ICollection<EnrollmentCourseSchedule> EnrollmentCourseSchedules { get; set; }
    }
}