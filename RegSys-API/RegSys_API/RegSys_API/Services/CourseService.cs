using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ISMS_API.Services
{
    public class CourseService : ICourseService
    {
        private RegSysDbContext _dbcontext;

        public CourseService(RegSysDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public int AddCourse(Course course)
        {
            _dbcontext.Courses.Add(course);
            return _dbcontext.SaveChanges();
        }

        public int DeactivateCourse(int ID)
        {
            Course toDeactivate = _dbcontext.Courses.AsNoTracking().Where(c => c.CourseId == ID).FirstOrDefault();
            //update IsActive
            toDeactivate.IsActive = false;
            _dbcontext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }

        public int ActivateCourse(int ID)
        {
            Course toActivate = _dbcontext.Courses.AsNoTracking().Where(c => c.CourseId == ID).FirstOrDefault();
            //update IsActive
            toActivate.IsActive = true;
            _dbcontext.Entry(toActivate).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }

        public int DeleteCourse(int ID)
        {
            Course toDelete = _dbcontext.Courses.AsNoTracking().Where(c => c.CourseId == ID).FirstOrDefault();
            _dbcontext.Entry(toDelete).State = EntityState.Deleted;
            return _dbcontext.SaveChanges();
        }

        public Course GetCourse(int ID)
        {
            return _dbcontext.Courses.AsNoTracking().Where(c => c.CourseId == ID).FirstOrDefault();
        }

        public IQueryable<Course> GetCourses()
        {
            return _dbcontext.Courses.Where(c => c.IsActive == true);
        }

        public bool IsCourseExist(Course Course)
        {
            Course toCheck = _dbcontext.Courses.Where(c => c.CourseCode == Course.CourseCode).FirstOrDefault();
            return (toCheck != null);
        }

        public int UpdateCourse(Course Course)
        {
            _dbcontext.Entry(Course).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }
    }
}