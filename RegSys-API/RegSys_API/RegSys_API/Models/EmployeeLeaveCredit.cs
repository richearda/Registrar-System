using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ISMS_API.Models
{
    public partial class EmployeeLeaveCredit
    {
        [Key]
        public int LeaveCreditsId { get; set; }
        public DateTime? DateAsOf { get; set; }
        public decimal? EarnedLeaveCredits { get; set; }
        public decimal? UsedLeaveCredits { get; set; }
        public decimal? UnusedLeaveCredits { get; set; }
        public decimal? TotalCredits { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
