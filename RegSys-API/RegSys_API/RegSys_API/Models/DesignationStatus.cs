using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class DesignationStatus
    {
        public DesignationStatus()
        {
            Employees = new HashSet<Employee>();
        }

        public int DesignationStatusId { get; set; }
        public string DesignationStatusDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
