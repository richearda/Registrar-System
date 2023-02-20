using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class LeaveType
    {
        public LeaveType()
        {
            LeaveApplications = new HashSet<LeaveApplication>();
        }

        public int LeaveTypeId { get; set; }
        public string LeaveTypeName { get; set; }
        public string LeaveTypeDescription { get; set; }

        public virtual ICollection<LeaveApplication> LeaveApplications { get; set; }
    }
}
