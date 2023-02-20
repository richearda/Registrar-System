using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class CityMunicipality
    {
        public CityMunicipality()
        {
            Addresses = new HashSet<Address>();
        }

        public int CityMunicipalityId { get; set; }
        public string CityMunicipalityName { get; set; }
        public bool? IsCity { get; set; }
        public string ZipCode { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Barangay> Barangays { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
