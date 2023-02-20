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
    public class BarangayService : IBarangayService
    {
        private RegSysDbContext _dbContext;
        private IMapper _mapper;

        public BarangayService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public int ActivateBarangay(int barangayId)
        {
            Barangay activateBarangay = _dbContext.Barangays.Where(b => b.BarangayId == barangayId).FirstOrDefault();
            activateBarangay.IsActive = true;
            _dbContext.Entry(activateBarangay).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int AddBarangay(Barangay barangay)
        {
            _dbContext.Barangays.Add(barangay);
            return _dbContext.SaveChanges();
        }

        public int DeactivateBarangay(int barangayId)
        {
            Barangay deactivateBarangay = _dbContext.Barangays.Where(b => b.BarangayId == barangayId).FirstOrDefault();
            deactivateBarangay.IsActive = false;
            _dbContext.Entry(deactivateBarangay).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteBarangay(int barangayId)
        {
            Barangay deleteBarangay = _dbContext.Barangays.Where(b => b.BarangayId == barangayId).FirstOrDefault();
            _dbContext.Entry(deleteBarangay).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public Barangay GetBarangay(int barangayId)
        {
            return _dbContext.Barangays.AsNoTracking().Where(b => b.BarangayId == barangayId).FirstOrDefault();
        }

        public IEnumerable<Barangay> GetBarangays()
        {
            return _dbContext.Barangays.Where(b => b.IsActive == true).OrderBy(b => b.BarangayName);
        }

        public Barangay GetBarangayByName(string barangayName)
        {
            return _dbContext.Barangays.Where(b => b.BarangayName == barangayName).FirstOrDefault();
        }

        public bool IsBarangayExist(Barangay barangay)
        {
            bool isTrue = false;
            if (_dbContext.Barangays.Any(b => b.BarangayName == barangay.BarangayName))
            { return isTrue = true; }
            return isTrue;
        }

        public int UpdateBarangay(Barangay barangay)
        {
            _dbContext.Entry(barangay).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public IEnumerable<Barangay> GetBarangaysByCityMunicipalityName(string cityMunicipalityName)
        {
            return _dbContext.Barangays.AsNoTracking().Where(b => b.CityMunicipality.CityMunicipalityName == cityMunicipalityName).ToList();
        }
    }
}