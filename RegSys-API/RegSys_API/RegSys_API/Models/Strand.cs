using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Strand
    {
        public Strand()
        {
            ShsSubjects = new HashSet<ShsSubject>();
        }

        public int StrandId { get; set; }
        public string StrandName { get; set; }
        public string StrandCode { get; set; }

        public virtual ICollection<ShsSubject> ShsSubjects { get; set; }
    }
}
