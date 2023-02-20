using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Province
    {
        public Province()
        {
            Addresses = new HashSet<Address>();
        }

        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
