using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Services
{
    public class MajorService : IMajorService
    {
        private RegSysDbContext _dbContext;

        public MajorService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddMajor(Major major)
        {
            _dbContext.Majors.Add(major);
            return _dbContext.SaveChanges();
        }

        public int UpdateMajor(Major Major)
        {
            _dbContext.Entry(Major).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteMajor(int ID)
        {
            Major toDelete = _dbContext.Majors.Where(s => s.MajorId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public Major GetMajor(int ID)
        {
            return _dbContext.Majors.AsNoTracking().Where(s => s.MajorId == ID).FirstOrDefault();
        }

        public Major GetMajorByName(string majorName)
        {
            return _dbContext.Majors.Where(m => m.MajorName == majorName).FirstOrDefault();
        }

        public IQueryable<Major> GetMajors()
        {
            return _dbContext.Majors.AsNoTracking().Where(s => s.IsActive == true);
        }

        public int ActivateMajor(int ID)
        {
            Major toActivate = _dbContext.Majors.Where(s => s.MajorId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivateMajor(int ID)
        {
            Major toDeactivate = _dbContext.Majors.Where(s => s.MajorId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public bool IsMajorExist(Major major)
        {
            Major checkMajor = _dbContext.Majors.Where(s => s.MajorName == major.MajorName).FirstOrDefault();
            return (checkMajor != null);
        }
    }
}