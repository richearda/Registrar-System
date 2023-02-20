using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ISMS_API.Services
{
    public class CitizenshipService : ICitizenshipService
    {
        private RegSysDbContext _dbContext;

        public CitizenshipService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddCitizenship(Citizenship Citizenship)
        {
            _dbContext.Citizenships.Add(Citizenship);
            return _dbContext.SaveChanges();
        }

        public int UpdateCitizenship(Citizenship Citizenship)
        {
            _dbContext.Entry(Citizenship).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteCitizenship(int ID)
        {
            Citizenship toDelete = _dbContext.Citizenships.Where(s => s.CitizenshipId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public Citizenship GetCitizenship(int ID)
        {
            return _dbContext.Citizenships.AsNoTracking().Where(s => s.CitizenshipId == ID).FirstOrDefault();
        }

        public IQueryable<Citizenship> GetCitizenships()
        {
            return _dbContext.Citizenships.AsNoTracking().Where(s => s.IsActive == true);
        }

        public int ActivateCitizenship(int ID)
        {
            Citizenship toActivate = _dbContext.Citizenships.Where(s => s.CitizenshipId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivateCitizenship(int ID)
        {
            Citizenship toDeactivate = _dbContext.Citizenships.Where(s => s.CitizenshipId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public bool IsCitizenshipExist(Citizenship Citizenship)
        {
            Citizenship checkCitizenship = _dbContext.Citizenships.Where(s => s.CitizenshipId == Citizenship.CitizenshipId).FirstOrDefault();
            return (checkCitizenship != null);
        }
    }
}