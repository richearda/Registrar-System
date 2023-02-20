using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ISMS_API.Services
{
    public class CivilStatusService : ICivilStatusService
    {
        private RegSysDbContext _dbContext;

        public CivilStatusService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddCivilStatus(CivilStatus civilStatus)
        {
            _dbContext.CivilStatuses.Add(civilStatus);
            return _dbContext.SaveChanges();
        }

        public int UpdateCivilStatus(CivilStatus civilStatus)
        {
            _dbContext.Entry(civilStatus).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteCivilStatus(int ID)
        {
            CivilStatus toDelete = _dbContext.CivilStatuses.Where(s => s.CivilStatusId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public CivilStatus GetCivilStatus(int ID)
        {
            return _dbContext.CivilStatuses.AsNoTracking().Where(s => s.CivilStatusId == ID).FirstOrDefault();
        }

        public IQueryable<CivilStatus> GetCivilStatuses()
        {
            return _dbContext.CivilStatuses.AsNoTracking().Where(s => s.IsActive == true);
        }

        public int ActivateCivilStatus(int ID)
        {
            CivilStatus toActivate = _dbContext.CivilStatuses.Where(s => s.CivilStatusId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivateCivilStatus(int ID)
        {
            CivilStatus toDeactivate = _dbContext.CivilStatuses.Where(s => s.CivilStatusId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public bool IsCivilStatusExist(CivilStatus CivilStatus)
        {
            CivilStatus checkCivilStatus = _dbContext.CivilStatuses.Where(s => s.CivilStatusId == CivilStatus.CivilStatusId).FirstOrDefault();
            return (checkCivilStatus != null);
        }
    }
}