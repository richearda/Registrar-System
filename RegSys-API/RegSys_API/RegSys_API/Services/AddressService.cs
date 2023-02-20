using AutoMapper;
using AutoMapper.QueryableExtensions;
using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Services
{
    public class AddressService : IAddressService
    {
        private RegSysDbContext _dbContext;
        private IMapper _mapper;
        private IBarangayService _barangayService;
        private ICityMunicipalityService _cityMunicipalityService;
        private IProvinceService _provinceService;
        private IAddressTypeService _addressTypeService;

        public AddressService(RegSysDbContext dbContext, IMapper mapper, IBarangayService barangayService, ICityMunicipalityService cityMunicipalityService, IProvinceService provinceService, IAddressTypeService addressTypeService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _barangayService = barangayService;
            _cityMunicipalityService = cityMunicipalityService;
            _provinceService = provinceService;
            _addressTypeService = addressTypeService;
        }

        public async Task<int> AddAddress(AddressDto addressDto)
        {
            var barangay = _barangayService.GetBarangayByName(addressDto.Barangay.BarangayName);
            var cityMunicipality = _cityMunicipalityService.GetCityMunicipalityByName(addressDto.CityMunicipality.CityMunicipalityName);
            var province = _provinceService.GetProvinceByName(addressDto.Province.ProvinceName);
            var addressType = _addressTypeService.GetAddressTypeByName(addressDto.AddressType.AddressTypeName);

            var address = _mapper.Map<Address>(addressDto);
            address.Barangay = barangay;
            address.CityMunicipality = cityMunicipality;
            address.Province = province;
            address.AddressType = addressType;

            await _dbContext.Addresses.AddAsync(address);
            await _dbContext.SaveChangesAsync();
            return address.AddressId;
        }

        public async Task<int> UpdateAddress(Address address)
        {
            _dbContext.Entry(address).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync();
        }

        public int DeleteAddress(int ID)
        {
            Address toDelete = _dbContext.Addresses.Where(s => s.AddressId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public AddressDto GetAddress(int ID)
        {
            return _dbContext.Addresses.Where(a => a.AddressId == ID).ProjectTo<AddressDto>(_mapper.ConfigurationProvider).FirstOrDefault();
        }

        public IQueryable<Address> GetAddresses()
        {
            return _dbContext.Addresses.AsNoTracking().AsQueryable();
        }

        public bool IsAddressExist(Address address)
        {
            Address checkAddress = _dbContext.Addresses.Where(s => s.AddressId == address.AddressId).FirstOrDefault();
            return (checkAddress != null);
        }
    }
}