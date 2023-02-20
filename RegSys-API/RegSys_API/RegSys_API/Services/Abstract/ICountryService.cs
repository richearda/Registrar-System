using ISMS_API.Models;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface ICountryService
    {
        int AddCountry(Country country);
        int UpdateCountry(Country country);
        int DeleteCountry(int countryID);
        IQueryable<Country> GetCountries();
        Country GetCountry(int countryID);
        int ActivateCountry(int ID);
        int DeactivateCountry(int ID);
        bool IsCountryExist(Country country);
    }
}
