using System;

#nullable disable

namespace ISMS_API.Models
{
    public partial class PersonVoluntaryWork
    {
        public int PersonVoluntaryWorkId { get; set; }
        public int? PersonId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationAddress { get; set; }
        public DateTime? InclusiveDateFrom { get; set; }
        public DateTime? InclusiveDateTo { get; set; }
        public double? NoOfHours { get; set; }
        public string Position { get; set; }
        public bool? IsActive { get; set; }

        public virtual Person Person { get; set; }
    }
}
