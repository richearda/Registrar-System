using ISMS_API.Models;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IGenderService
    {
        int AddGender(Gender gender);
        int UpdateGender(Gender gender);
        int DeleteGender(int genderID);
        IQueryable<Gender> GetGenders();
        Gender GetGender(int genderID);
        int ActivateGender(int ID);
        int DeactivateGender(int ID);
        bool IsGenderExist(Gender Gender);
    }
}
