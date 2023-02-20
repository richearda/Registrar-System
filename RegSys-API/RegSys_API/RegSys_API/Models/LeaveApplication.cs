using System;

#nullable disable

namespace ISMS_API.Models
{
    public partial class LeaveApplication
    {
        public int LeaveApplicationId { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public decimal? NoOfDaysAppliedFor { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsWithCommutation { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public int? ApplicationStatusId { get; set; }

        public virtual LeaveApplicationStatus ApplicationStatus { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual LeaveType LeaveType { get; set; }
    }
}
