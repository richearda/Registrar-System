using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public class Address
    {
       
        public int AddressId { get; set; }
        public string HouseBlkLotNo { get; set; }
        public string Street { get; set; }
        public string SubdivisionVillage { get; set; }
        public int? BarangayId { get; set; }
        public int? CityMunicipalityId { get; set; }
        public int? ProvinceId { get; set; }
        public int? AddressTypeId { get; set; }

        public virtual AddressType AddressType { get; set; }
        public virtual Barangay Barangay { get; set; }
        public virtual CityMunicipality CityMunicipality { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
