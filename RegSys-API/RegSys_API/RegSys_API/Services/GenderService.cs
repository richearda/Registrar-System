using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ISMS_API.Services
{
    public class GenderService : IGenderService
    {
        private readonly RegSysDbContext _dbContext;

        public GenderService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddGender(Gender gender)
        {
            _dbContext.Genders.Add(gender);
            return _dbContext.SaveChanges();
        }

        public int UpdateGender(Gender gender)
        {
            _dbContext.Entry(gender).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteGender(int genderID)
        {
            Gender toDelete = _dbContext.Genders.Where(s => s.GenderId == genderID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public Gender GetGender(int genderID)
        {
            return _dbContext.Genders.AsNoTracking().Where(s => s.GenderId == genderID).FirstOrDefault();
        }

        public IQueryable<Gender> GetGenders()
        {
            return _dbContext.Genders.AsNoTracking().Where(s => s.IsActive == true);
        }

        public int ActivateGender(int ID)
        {
            Gender toActivate = _dbContext.Genders.Where(s => s.GenderId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivateGender(int ID)
        {
            Gender toDeactivate = _dbContext.Genders.Where(s => s.GenderId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public bool IsGenderExist(Gender Gender)
        {
            Gender checkGender = _dbContext.Genders.Where(s => s.GenderId == Gender.GenderId).FirstOrDefault();
            return (checkGender != null);
        }
    }
}