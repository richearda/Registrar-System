using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Day
    {
        public Day()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
            ShsSubjectSchedules = new HashSet<ShsSubjectSchedule>();
        }

        public int DayId { get; set; }
        public string DayName { get; set; }
        public string DayCode { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
        public virtual ICollection<ShsSubjectSchedule> ShsSubjectSchedules { get; set; }
    }
}
