using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ISMS_API.Services
{
    public class CollegeService : ICollegeService
    {
        private RegSysDbContext _dbcontext;

        public CollegeService(RegSysDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public int AddCollege(College college)
        {
            _dbcontext.Colleges.Add(college);
            return _dbcontext.SaveChanges();
        }

        public int DeactivateCollege(int ID)
        {
            College toDeactivate = _dbcontext.Colleges.AsNoTracking().Where(c => c.CollegeId == ID).FirstOrDefault();
            //update IsActive
            toDeactivate.IsActive = false;
            _dbcontext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }

        public int ActivateCollege(int ID)
        {
            College toActivate = _dbcontext.Colleges.AsNoTracking().Where(c => c.CollegeId == ID).FirstOrDefault();
            //update IsActive
            toActivate.IsActive = true;
            _dbcontext.Entry(toActivate).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }

        public int DeleteCollege(int ID)
        {
            College toDelete = _dbcontext.Colleges.AsNoTracking().Where(c => c.CollegeId == ID).FirstOrDefault();
            _dbcontext.Entry(toDelete).State = EntityState.Deleted;
            return _dbcontext.SaveChanges();
        }

        public College GetCollege(int ID)
        {
            return _dbcontext.Colleges.AsNoTracking().Where(c => c.CollegeId == ID).FirstOrDefault();
        }

        public IQueryable<College> GetColleges()
        {
            return _dbcontext.Colleges.Where(c => c.IsActive == true);
        }

        public IQueryable<College> GetInactiveColleges()
        {
            return _dbcontext.Colleges.Where(c => c.IsActive == false);
        }

        public bool IsCollegeExist(College college)
        {
            College toCheck = _dbcontext.Colleges.Where(c => c.CollegeName == college.CollegeName).FirstOrDefault();
            return (toCheck != null);
        }

        public int UpdateCollege(College college)
        {
            _dbcontext.Entry(college).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }
    }
}