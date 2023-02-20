using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Country
    {
        public Country()
        {
            People = new HashSet<Person>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
