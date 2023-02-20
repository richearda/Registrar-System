using System;

#nullable disable

namespace ISMS_API.Models
{
    public partial class EmployeeSchedule
    {
        public int EmployeeScheduleId { get; set; }
        public TimeSpan? TimeStart { get; set; }
        public int? MidDayIdtimeStart { get; set; }
        public TimeSpan? TimeEnd { get; set; }
        public int? MidDayIdtimeEnd { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
