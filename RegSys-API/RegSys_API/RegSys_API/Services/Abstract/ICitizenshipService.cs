using ISMS_API.Models;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface ICitizenshipService
    {
        int AddCitizenship(Citizenship citizenship);
        int UpdateCitizenship(Citizenship citizenship);
        int DeleteCitizenship(int citizenshipID);
        IQueryable<Citizenship> GetCitizenships();
        Citizenship GetCitizenship(int citizenshipID);
        int ActivateCitizenship(int ID);
        int DeactivateCitizenship(int ID);
        bool IsCitizenshipExist(Citizenship citizenship);
    }
}
