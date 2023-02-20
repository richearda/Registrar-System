using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class AddressType
    {
        public AddressType()
        {
            Addresses = new HashSet<Address>();
        }

        public int AddressTypeId { get; set; }
        public string AddressTypeName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
