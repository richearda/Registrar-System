using ISMS_API.Models;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface ICollegeService
    {
        IQueryable<College> GetColleges();
        IQueryable<College> GetInactiveColleges();
        int AddCollege(College college);
        int UpdateCollege(College college);
        int ActivateCollege(int ID);
        int DeactivateCollege(int ID);
        int DeleteCollege(int ID);
        bool IsCollegeExist(College college);
        College GetCollege(int ID);
    }
}