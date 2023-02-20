using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Barangay
    {
        public Barangay()
        {
            Addresses = new HashSet<Address>();
        }

        public int BarangayId { get; set; }
        public string BarangayName { get; set; }
        public bool? IsActive { get; set; }
        public int CityMunicipalityId { get; set; }

        public CityMunicipality CityMunicipality  { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
