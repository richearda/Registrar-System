using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class GovernmentIssuedIdentification
    {
        public GovernmentIssuedIdentification()
        {
            PersonOathDeclarations = new HashSet<PersonOathDeclaration>();
        }

        public int GovernmentIssuedIdentificationId { get; set; }
        public string IssuedIdentificationType { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<PersonOathDeclaration> PersonOathDeclarations { get; set; }
    }
}
