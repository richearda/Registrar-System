using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class DualCitizenshipAcquisition
    {
        public DualCitizenshipAcquisition()
        {
            People = new HashSet<Person>();
        }

        public int DualCitizenshipAcquisitionId { get; set; }
        public string DualCitizenshipAcquisitionType { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
