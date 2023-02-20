using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentCourseSchedules = new HashSet<StudentCourseSchedule>();
        }

        public int StudentId { get; set; }
        public string StudentNo { get; set; }
        public string Lrnno { get; set; }
        public int? PersonId { get; set; }
        public int? ProgramId { get; set; }
        public int? MajorId { get; set; }
        //public int? EnrollmentId { get; set; }
        public string YearLevel { get; set; }
        public bool? IsActive { get; set; }

        public virtual Major Major { get; set; }
        public virtual Person Person { get; set; }
        public virtual Program Program { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<StudentCourseSchedule> StudentCourseSchedules { get; set; }
        public virtual ICollection<Payable> Payables { get; set; }
    }
}
