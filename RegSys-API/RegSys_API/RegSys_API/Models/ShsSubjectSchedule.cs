using System;
using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class ShsSubjectSchedule
    {
        public ShsSubjectSchedule()
        {
            TeacherShsSubjectSchedules = new HashSet<TeacherShsSubjectSchedule>();
        }

        public int SubjectScheduleId { get; set; }
        public int? SubjectId { get; set; }
        public int? DayId { get; set; }
        public TimeSpan? TimeStart { get; set; }
        public int? MidDayIdtimeStart { get; set; }
        public TimeSpan? TimeEnd { get; set; }
        public int? MidDayIdtimeEnd { get; set; }
        public string Section { get; set; }
        public int? SemesterId { get; set; }

        public virtual Day Day { get; set; }
        public virtual MidDay MidDayIdtimeEndNavigation { get; set; }
        public virtual MidDay MidDayIdtimeStartNavigation { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual ShsSubject Subject { get; set; }
        public virtual ICollection<TeacherShsSubjectSchedule> TeacherShsSubjectSchedules { get; set; }
    }
}
