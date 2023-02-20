#nullable disable

namespace ISMS_API.Models
{
    public partial class PersonOrganizationMembershipInformation
    {
        public int PersonOrganizationMembershipInformationId { get; set; }
        public int? PersonId { get; set; }
        public string MembershipDetails { get; set; }
        public bool? IsActive { get; set; }

        public virtual Person Person { get; set; }
    }
}
