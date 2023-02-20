using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services
{
    public class ProvinceService : IProvinceService
    {
        private RegSysDbContext _dbContext;

        public ProvinceService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddProvince(Province province)
        {
            _dbContext.Provinces.Add(province);
            return _dbContext.SaveChanges();
        }

        public int UpdateProvince(Province province)
        {
            _dbContext.Entry(province).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteProvince(int ID)
        {
            Province toDelete = _dbContext.Provinces.Where(s => s.ProvinceId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public Province GetProvince(int ID)
        {
            return _dbContext.Provinces.AsNoTracking().Where(s => s.ProvinceId == ID).FirstOrDefault();
        }

        public Province GetProvinceByName(string provinceName)
        {
            return _dbContext.Provinces.Where(p => p.ProvinceName == provinceName).FirstOrDefault();
        }

        public IEnumerable<Province> GetProvinces()
        {
            return _dbContext.Provinces.AsNoTracking().Where(s => s.IsActive == true).OrderBy(p => p.ProvinceName);
        }

        public int ActivateProvince(int ID)
        {
            Province toActivate = _dbContext.Provinces.Where(s => s.ProvinceId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivateProvince(int ID)
        {
            Province toDeactivate = _dbContext.Provinces.Where(s => s.ProvinceId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public bool IsProvinceExist(Province Province)
        {
            Province checkProvince = _dbContext.Provinces.Where(s => s.ProvinceName == Province.ProvinceName).FirstOrDefault();
            return (checkProvince != null);
        }
    }
}