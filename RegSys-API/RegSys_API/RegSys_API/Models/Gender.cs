using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public class Gender
    {
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
