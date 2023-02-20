using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;

namespace ISMS_API.Models
{
    public class Block
    {
        public int BlockId { get; set; }
        public string BlockName { get; set; }
        public int ProgramId { get; set; }
        public int MajorId { get; set; }
        public int TermId { get; set; }
        public int SemesterId { get; set; }

        public bool IsActive { get; set; }

        public Program Program { get; set; }
        public Major Major { get; set; }
        public Term Term { get; set; }
        public Semester Semester { get; set; }

        // public ICollection<EnrollmentCourseSchedule> EnrollmentCourseSchedules { get; set; }
        public ICollection<BlockCourseSchedule> BlockCourseSchedules { get; set; }
    }
}