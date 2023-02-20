using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class EmployeeClassification
    {
        public EmployeeClassification()
        {
            Employees = new HashSet<Employee>();
        }

        public int EmployeeClassificationId { get; set; }
        public string EmployeeClassificationDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
