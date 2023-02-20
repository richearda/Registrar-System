using ISMS_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface ICityMunicipalityService
    {
        int AddCityMunicipality(CityMunicipality cityMunicipality);
        int UpdateCityMunicipality(CityMunicipality cityMunicipality);
        int DeleteCityMunicipality(int cityMunicipalityID);
        IEnumerable<CityMunicipality> GetCityMunicipalities();
        CityMunicipality GetCityMunicipality(int cityMunicipalityID);
        CityMunicipality GetCityMunicipalityByName(string cityMunicipalityName);
        int ActivateCityMunicipality(int ID);
        int DeactivateCityMunicipality(int ID);
        bool IsCityMunicipalityExist(CityMunicipality cityMunicipality);
        //IEnumerable<CityMunicipality> GetCityMunicipalityByCountry(string countryName);
    }
}
