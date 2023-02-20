using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class BloodType
    {
        public BloodType()
        {
            People = new HashSet<Person>();
        }

        public int BloodTypeId { get; set; }
        public string BloodTypeClassification { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
