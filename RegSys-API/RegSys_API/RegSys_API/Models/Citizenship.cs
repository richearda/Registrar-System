using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Citizenship
    {
        public Citizenship()
        {
            People = new HashSet<Person>();
        }

        public int CitizenshipId { get; set; }
        public string CitizenshipStatus { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
