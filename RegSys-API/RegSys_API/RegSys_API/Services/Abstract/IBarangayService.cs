using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IBarangayService
    {
        IEnumerable<Barangay> GetBarangays();
        int AddBarangay(Barangay barangay);
        int UpdateBarangay(Barangay barangay);
        int ActivateBarangay(int barangayId);
        int DeactivateBarangay(int barangayId);
        int DeleteBarangay(int barangayId);
        bool IsBarangayExist(Barangay barangay);
        Barangay GetBarangay(int barangayId);
        Barangay GetBarangayByName(string barangayName);
        IEnumerable<Barangay> GetBarangaysByCityMunicipalityName(string cityMunicipalityName);
    }
}
