using ISMS_API.Models;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IAddressTypeService
    {
        int AddAddressType(AddressType addressType);
        int UpdateAddressType(AddressType addressType);
        int DeleteAddressType(int addressTypeID);
        IQueryable<AddressType> GetAddressTypes();
        AddressType GetAddressType(int addressTypeID);
        AddressType GetAddressTypeByName(string AddressTypeByName);
        int ActivateAddressType(int ID);
        int DeactivateAddressType(int ID);
        bool IsAddressTypeExist(AddressType addressType);
    }
}
