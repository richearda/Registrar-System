using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Services.Abstract
{
    public interface IAddressService
    {
        Task<int> AddAddress(AddressDto addressDto);
        Task<int> UpdateAddress(Address Address);
        int DeleteAddress(int addressID);
        IQueryable<Address> GetAddresses();
        AddressDto GetAddress(int addressID);
        bool IsAddressExist(Address address);
    }
}
