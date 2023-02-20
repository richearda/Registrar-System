using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ISMS_API.Models
{
    public partial class MidDay
    {
        [Key]
        public int MidDayId { get; set; }
        public string MidDayName { get; set; }
        public bool? IsActive { get; set; }


        public virtual ICollection<CourseSchedule> CourseScheduleMidDayIdtimeEndNavigations { get; set; }
        public virtual ICollection<CourseSchedule> CourseScheduleMidDayIdtimeStartNavigations { get; set; }
        public virtual ICollection<ShsSubjectSchedule> ShsSubjectScheduleMidDayIdtimeEndNavigations { get; set; }
        public virtual ICollection<ShsSubjectSchedule> ShsSubjectScheduleMidDayIdtimeStartNavigations { get; set; }
    }
}
