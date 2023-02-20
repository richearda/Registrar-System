using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class AppointmentStatus
    {
        public AppointmentStatus()
        {
            PersonWorkExperiences = new HashSet<PersonWorkExperience>();
        }

        public int AppointmentStatusId { get; set; }
        public string AppointmentStatusDescription { get; set; }
        public string IsActive { get; set; }

        public virtual ICollection<PersonWorkExperience> PersonWorkExperiences { get; set; }
    }
}
