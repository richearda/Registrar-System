using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class LeaveApplicationStatus
    {
        public LeaveApplicationStatus()
        {
            LeaveApplications = new HashSet<LeaveApplication>();
        }

        public int ApplicationStatusId { get; set; }
        public bool? IsApproved { get; set; }
        public decimal? TotalDaysApproved { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LeaveApplication> LeaveApplications { get; set; }
    }
}
