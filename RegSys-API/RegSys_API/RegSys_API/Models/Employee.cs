using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeLeaveCredits = new HashSet<EmployeeLeaveCredit>();
            EmployeeSchedules = new HashSet<EmployeeSchedule>();
            LeaveApplications = new HashSet<LeaveApplication>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeNo { get; set; }
        public int? PersonId { get; set; }
        public int? EmployeeClassificationId { get; set; }
        public string ResolutionNo { get; set; }
        public string Designation { get; set; }
        public int? DesignationStatusId { get; set; }
        public string Gsisidno { get; set; }
        public string Hdmfidno { get; set; }
        public string PhilHealthNo { get; set; }
        public string Sssidno { get; set; }
        public string Tinidno { get; set; }
        public bool? IsActive { get; set; }

        public virtual DesignationStatus DesignationStatus { get; set; }
        public virtual EmployeeClassification EmployeeClassification { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<EmployeeLeaveCredit> EmployeeLeaveCredits { get; set; }
        public virtual ICollection<EmployeeSchedule> EmployeeSchedules { get; set; }
        public virtual ICollection<LeaveApplication> LeaveApplications { get; set; }
    }
}
