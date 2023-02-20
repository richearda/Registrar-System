using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services
{
    public class CityMunicipalityservice : ICityMunicipalityService
    {
        private RegSysDbContext _dbContext;

        public CityMunicipalityservice(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddCityMunicipality(CityMunicipality cityMunicipality)
        {
            _dbContext.CityMunicipalities.Add(cityMunicipality);
            return _dbContext.SaveChanges();
        }

        public int UpdateCityMunicipality(CityMunicipality cityMunicipality)
        {
            _dbContext.Entry(cityMunicipality).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteCityMunicipality(int ID)
        {
            CityMunicipality toDelete = _dbContext.CityMunicipalities.Where(s => s.CityMunicipalityId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public CityMunicipality GetCityMunicipality(int ID)
        {
            return _dbContext.CityMunicipalities.AsNoTracking().Where(s => s.CityMunicipalityId == ID).FirstOrDefault();
        }

        public CityMunicipality GetCityMunicipalityByName(string cityMunicipalityName)
        {
            return _dbContext.CityMunicipalities.Where(c => c.CityMunicipalityName == cityMunicipalityName).FirstOrDefault();
        }

        public IEnumerable<CityMunicipality> GetCityMunicipalities()
        {
            return _dbContext.CityMunicipalities.AsNoTracking().Where(s => s.IsActive == true).OrderBy(c => c.CityMunicipalityName);
        }

        public int ActivateCityMunicipality(int ID)
        {
            CityMunicipality toActivate = _dbContext.CityMunicipalities.Where(s => s.CityMunicipalityId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivateCityMunicipality(int ID)
        {
            CityMunicipality toDeactivate = _dbContext.CityMunicipalities.Where(s => s.CityMunicipalityId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public bool IsCityMunicipalityExist(CityMunicipality CityMunicipality)
        {
            CityMunicipality checkCityMunicipality = _dbContext.CityMunicipalities.Where(s => s.CityMunicipalityId == CityMunicipality.CityMunicipalityId).FirstOrDefault();
            return (checkCityMunicipality != null);
        }

        //public IEnumerable<CityMunicipality> GetCityMunicipalityByCountry(string countryName)
        //{
        //_dbContext.CityMunicipalities.AsNoTracking().Where(c => c.Coun)
        //}
    }
}