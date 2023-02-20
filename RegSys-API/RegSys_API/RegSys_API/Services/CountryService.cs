using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ISMS_API.Services
{
    public class CountryService : ICountryService
    {
        private RegSysDbContext _dbContext;

        public CountryService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddCountry(Country country)
        {
            _dbContext.Countries.Add(country);
            return _dbContext.SaveChanges();
        }

        public int UpdateCountry(Country Country)
        {
            _dbContext.Entry(Country).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteCountry(int ID)
        {
            Country toDelete = _dbContext.Countries.Where(s => s.CountryId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public Country GetCountry(int ID)
        {
            return _dbContext.Countries.AsNoTracking().Where(s => s.CountryId == ID).FirstOrDefault();
        }

        public IQueryable<Country> GetCountries()
        {
            return _dbContext.Countries.AsNoTracking().Where(s => s.IsActive == true);
        }

        public int ActivateCountry(int ID)
        {
            Country toActivate = _dbContext.Countries.Where(s => s.CountryId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivateCountry(int ID)
        {
            Country toDeactivate = _dbContext.Countries.Where(s => s.CountryId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public bool IsCountryExist(Country Country)
        {
            Country checkCountry = _dbContext.Countries.Where(s => s.CountryId == Country.CountryId).FirstOrDefault();
            return (checkCountry != null);
        }
    }
}