using System.Collections.Generic;

namespace ISMS_API.DTOs
{
    public class AddressDto
    {
        public string HouseBlkLotNo { get; set; }
        public string Street { get; set; }
        public string SubdivisionVillage { get; set; }
        public BarangayDto Barangay { get; set; }
        public CityMunicipalityDto CityMunicipality { get; set; }
        public ProvinceDto Province { get; set; }
        public AddressTypeDto AddressType { get; set; }
    }
}
