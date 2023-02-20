using ISMS_API.Models;
using System.Linq;


namespace ISMS_API.Services.Abstract
{
    public interface ICourseService
    {
        IQueryable<Course> GetCourses();
        int AddCourse(Course Course);
        int UpdateCourse(Course Course);
        int ActivateCourse(int ID);
        int DeactivateCourse(int ID);
        int DeleteCourse(int ID);
        bool IsCourseExist(Course Course);
        Course GetCourse(int ID);
    }
}
