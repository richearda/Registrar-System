using ISMS_API.Data;
using ISMS_API.Services.Abstract;

namespace ISMS_API.Services
{
    public class CourseTypeService : ICourseTypeService
    {
        private RegSysDbContext _dbContext;

        public CourseTypeService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /*public int ActivateCourseType(int courseTypeId)
        {
            CourseType activateCourseType = _dbContext.CourseTypes.Where(ct => ct.CourseTypeID == courseTypeId).FirstOrDefault();
            activateCourseType.IsActive = true;
            _dbContext.Entry(activateCourseType).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int AddCourseType(CourseType courseType)
        {
            _dbContext.CourseTypes.Add(courseType);
            return _dbContext.SaveChanges();
        }

        public int DeactivateCourseType(int courseTypeId)
        {
            CourseType deactivateCourseType = _dbContext.CourseTypes.Where(ct => ct.CourseTypeID == courseTypeId).FirstOrDefault();
            deactivateCourseType.IsActive = false;
            _dbContext.Entry(deactivateCourseType).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteCourseType(int courseTypeId)
        {
            CourseType toDelete = _dbContext.CourseTypes.Where(ct => ct.CourseTypeID == courseTypeId).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public CourseType GetCourseType(int courseTypeId)
        {
            return _dbContext.CourseTypes.AsNoTracking().Where(ct => ct.CourseTypeID == courseTypeId).FirstOrDefault();
        }

        public IQueryable<CourseType> GetCourseTypes()
        {
            return _dbContext.CourseTypes.Where(ct => ct.IsActive == true);
        }

        public bool IsCourseTypeExist(CourseType courseType)
        {
            bool isTrue = false;
            if (_dbContext.CourseTypes.Any(ct => ct.CourseTypeName == courseType.CourseTypeName && ct.CourseTypeDescription == courseType.CourseTypeDescription))
            { return isTrue = true; }
            return isTrue;
        }

        public int UpdateCourseType(CourseType courseType)
        {
            _dbContext.Entry(courseType).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }*/
    }
}