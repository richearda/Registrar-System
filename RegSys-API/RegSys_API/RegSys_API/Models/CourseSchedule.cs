using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ISMS_API.Models
{
    public partial class CourseSchedule
    {
        public int CourseScheduleId { get; set; }
        public string Edpcode { get; set; }
        public int? CourseId { get; set; }
        public int? DayId { get; set; }
        public TimeSpan? TimeStart { get; set; }

        [ForeignKey("MidDayIdtimeStartNavigation")]
        public int? MidDayIdtimeStart { get; set; }

        public TimeSpan? TimeEnd { get; set; }

        [ForeignKey("MidDayIdtimeEndNavigation")]
        public int? MidDayIdtimeEnd { get; set; }

        public int? RoomId { get; set; }
        public int? TermId { get; set; }
        public int? SemesterId { get; set; }

        public bool? IsActive { get; set; }

        public virtual Course Course { get; set; }
        public virtual Day Day { get; set; }
        public virtual MidDay MidDayIdtimeEndNavigation { get; set; }
        public virtual MidDay MidDayIdtimeStartNavigation { get; set; }
        public virtual Room Room { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual Term Term { get; set; }

        public virtual ICollection<StudentCourseSchedule> StudentCourseSchedules { get; set; }
        public virtual ICollection<TeacherCourseSchedule> TeacherCourseSchedules { get; set; }
        public virtual ICollection<EnrollmentCourseSchedule> EnrollmentCourseSchedules { get; set; }
    }
}