using ISMS_API.Models;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface ICivilStatusService
    {
        int AddCivilStatus(CivilStatus civilStatus);
        int UpdateCivilStatus(CivilStatus civilStatus);
        int DeleteCivilStatus(int civilStatusID);
        IQueryable<CivilStatus> GetCivilStatuses();
        CivilStatus GetCivilStatus(int civilStatusID);
        int ActivateCivilStatus(int ID);
        int DeactivateCivilStatus(int ID);
        bool IsCivilStatusExist(CivilStatus civilStatus);
    }
}
