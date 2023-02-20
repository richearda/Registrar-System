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
    public class StudentService : IStudentService
    {
        private RegSysDbContext _dbContext;
        private IMapper _mapper;
        private IProgramService _programService;
        private IMajorService _majorService;
        private IBarangayService _barangayService;
        private ICityMunicipalityService _cityMunicipalityService;
        private IProvinceService _provinceService;
        private IAddressTypeService _addressTypeService;

        public StudentService(RegSysDbContext dbContext, IMapper mapper,
            IProgramService programService,
            IMajorService majorService,
            IBarangayService barangayService,
            ICityMunicipalityService cityMunicipalityService,
            IProvinceService provinceService,
            IAddressTypeService addressTypeService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _programService = programService;
            _majorService = majorService;
            _barangayService = barangayService;
            _cityMunicipalityService = cityMunicipalityService;
            _provinceService = provinceService;
            _addressTypeService = addressTypeService;
        }

        public int AddStudent(StudentDto studentDto)
        {
            var program = _programService.GetProgramByName(studentDto.Program.ProgramName);
            var major = _majorService.GetMajorByName(studentDto.Major.MajorName);

            var gender = _dbContext.Genders.Where(g => g.GenderName == studentDto.Person.Gender.GenderName).FirstOrDefault();
            var civilStatus = _dbContext.CivilStatuses.Where(c => c.CivilStatusType == studentDto.Person.CivilStatus.CivilStatusType).FirstOrDefault();
            var citizenship = _dbContext.Citizenships.Where(c => c.CitizenshipStatus == studentDto.Person.Citizenship.CitizenshipStatus).FirstOrDefault();
            var country = _dbContext.Countries.Where(c => c.CountryName == studentDto.Person.Country.CountryName).FirstOrDefault();

            var student = _mapper.Map<Student>(studentDto);
            student.Program = program;
            student.Major = major;
            student.Person = _mapper.Map<Person>(studentDto.Person);
            student.Person.Gender = gender;
            student.Person.CivilStatus = civilStatus;
            student.Person.Citizenship = citizenship;
            student.Person.Country = country;

            Address address = new Address
            {
                HouseBlkLotNo = studentDto.Person.Address.HouseBlkLotNo,
                Street = studentDto.Person.Address.Street,
                SubdivisionVillage = studentDto.Person.Address.SubdivisionVillage,
                Barangay = _barangayService.GetBarangayByName(studentDto.Person.Address.Barangay.BarangayName),
                CityMunicipality = _cityMunicipalityService.GetCityMunicipalityByName(studentDto.Person.Address.CityMunicipality.CityMunicipalityName),
                Province = _provinceService.GetProvinceByName(studentDto.Person.Address.Province.ProvinceName),
                AddressType = _addressTypeService.GetAddressTypeByName(studentDto.Person.Address.AddressType.AddressTypeName)
            };

            student.Person.Address = address;

            _dbContext.Students.Add(student);
            return _dbContext.SaveChanges();
        }

        public int UpdateStudent(StudentDto student)
        {
            _dbContext.Entry(student).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteStudent(int ID)
        {
            Student toDelete = _dbContext.Students.Where(s => s.StudentId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public StudentDto GetStudent(int Id)
        {
            return _dbContext.Students.Where(s => s.StudentId == Id).ProjectTo<StudentDto>(_mapper.ConfigurationProvider).FirstOrDefault();
        }

        public IQueryable<Student> GetStudents()
        {
            return _dbContext.Students.AsNoTracking().Where(s => s.IsActive == true);
        }

        public IEnumerable<EnrolleeDto> GetEnrollees()
        {
            var enrollees = _dbContext.Students.Where(s => s.IsActive == true).ProjectTo<EnrolleeDto>(_mapper.ConfigurationProvider).ToList();
            return enrollees;
        }

        public int ActivateStudent(int ID)
        {
            Student toActivate = _dbContext.Students.Where(s => s.StudentId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivateStudent(int ID)
        {
            Student toDeactivate = _dbContext.Students.Where(s => s.StudentId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public bool IsStudentExist(StudentDto studentDto)
        {
            Student checkStudent = _dbContext.Students.Where(s => s.StudentNo == studentDto.StudentNo).ProjectTo<Student>(_mapper.ConfigurationProvider).FirstOrDefault();
            return (checkStudent != null);
        }

        public List<GetStudentEnrollmentsDto> GetStudentEnrollments(int studentID)
        {
            return _dbContext.Enrollments.Where(e => e.StudentId == studentID).ProjectTo<GetStudentEnrollmentsDto>(_mapper.ConfigurationProvider).ToList();
        }
    }
}