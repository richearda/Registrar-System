using AutoMapper;
using AutoMapper.QueryableExtensions;
using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services
{
    public class PersonService : IPersonService
    {
        private RegSysDbContext _dbContext;
        private IMapper _mapper;
        private IAddressService _addressService;
        private IBarangayService _barangayService;
        private ICityMunicipalityService _cityMunicipalityService;
        private IProvinceService _provinceService;
        private IAddressTypeService _addressTypeService;

        public PersonService(RegSysDbContext dbContext, IMapper mapper, IAddressService addressService, IBarangayService barangayService, ICityMunicipalityService cityMunicipalityService, IProvinceService provinceService, IAddressTypeService addressTypeService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _addressService = addressService;
            _barangayService = barangayService;
            _cityMunicipalityService = cityMunicipalityService;
            _provinceService = provinceService;
            _addressTypeService = addressTypeService;
        }

        public int AddPerson(PersonDto personDto)
        {
            var gender = _dbContext.Genders.Where(g => g.GenderName == personDto.Gender.GenderName).FirstOrDefault();
            var civilStatus = _dbContext.CivilStatuses.Where(c => c.CivilStatusType == personDto.CivilStatus.CivilStatusType).FirstOrDefault();
            var citizenship = _dbContext.Citizenships.Where(c => c.CitizenshipStatus == personDto.Citizenship.CitizenshipStatus).FirstOrDefault();
            var country = _dbContext.Countries.Where(c => c.CountryName == personDto.Country.CountryName).FirstOrDefault();

            Address address = new Address
            {
                HouseBlkLotNo = personDto.Address.HouseBlkLotNo,
                Street = personDto.Address.Street,
                SubdivisionVillage = personDto.Address.SubdivisionVillage,
                Barangay = _barangayService.GetBarangayByName(personDto.Address.Barangay.BarangayName),
                CityMunicipality = _cityMunicipalityService.GetCityMunicipalityByName(personDto.Address.CityMunicipality.CityMunicipalityName),
                Province = _provinceService.GetProvinceByName(personDto.Address.Province.ProvinceName),
                AddressType = _addressTypeService.GetAddressTypeByName(personDto.Address.AddressType.AddressTypeName)
            };

            _dbContext.Addresses.Add(address);

            // _mapper.ConfigurationProvider.AssertConfigurationIsValid();
            var person = _mapper.Map<Person>(personDto);
            person.Gender = gender;
            person.CivilStatus = civilStatus;
            person.Citizenship = citizenship;
            person.Country = country;
            person.Address = address;
            _dbContext.People.Add(person);

            return _dbContext.SaveChanges();
        }

        public int UpdatePerson(PersonDto personDto)
        {
            var person = _mapper.Map<Person>(personDto);
            _dbContext.Entry(person).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeletePerson(int ID)
        {
            Person toDelete = _dbContext.People.Where(s => s.PersonId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public PersonDto GetPerson(int ID)
        {
            var person = _dbContext.People.AsNoTracking().Where(s => s.PersonId == ID).FirstOrDefault();
            return _mapper.Map<PersonDto>(person);
        }

        public IEnumerable<PersonDto> GetPeople()
        {
            var people = _dbContext.People.AsNoTracking().Where(p => p.IsActive == true).ProjectTo<PersonDto>(_mapper.ConfigurationProvider).ToList();
            return people;
        }

        public int ActivatePerson(int ID)
        {
            Person toActivate = _dbContext.People.Where(s => s.PersonId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivatePerson(int ID)
        {
            Person toDeactivate = _dbContext.People.Where(s => s.PersonId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public bool IsPersonExist(Person Person)
        {
            Person checkPerson = _dbContext.People.Where(s => s.PersonId == Person.PersonId).FirstOrDefault();
            return (checkPerson != null);
        }
    }
}