using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class CivilStatus
    {
        public CivilStatus()
        {
            People = new HashSet<Person>();
        }

        public int CivilStatusId { get; set; }
        public string CivilStatusType { get; set; }
        public string CivilStatusCode { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
