using ISMS_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IProvinceService
    {
        int AddProvince(Province province);
        int UpdateProvince(Province province);
        int DeleteProvince(int provinceID);
        IEnumerable<Province> GetProvinces();
        Province GetProvince(int provinceID);
        Province GetProvinceByName(string provinceName);
        int ActivateProvince(int ID);
        int DeactivateProvince(int ID);
        bool IsProvinceExist(Province province);
    }
}
