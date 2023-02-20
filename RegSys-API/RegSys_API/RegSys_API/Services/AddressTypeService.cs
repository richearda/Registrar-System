using ISMS_API.Data;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ISMS_API.Services
{
    public class AddressTypeService : IAddressTypeService
    {
        private RegSysDbContext _dbContext;

        public AddressTypeService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddAddressType(AddressType addressType)
        {
            _dbContext.AddressTypes.Add(addressType);
            return _dbContext.SaveChanges();
        }

        public int UpdateAddressType(AddressType AddressType)
        {
            _dbContext.Entry(AddressType).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteAddressType(int ID)
        {
            AddressType toDelete = _dbContext.AddressTypes.Where(s => s.AddressTypeId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public AddressType GetAddressType(int ID)
        {
            return _dbContext.AddressTypes.AsNoTracking().Where(s => s.AddressTypeId == ID).FirstOrDefault();
        }

        public AddressType GetAddressTypeByName(string addressTypeName)
        {
            return _dbContext.AddressTypes.Where(a => a.AddressTypeName == addressTypeName).FirstOrDefault();
        }

        public IQueryable<AddressType> GetAddressTypes()
        {
            return _dbContext.AddressTypes.AsNoTracking().Where(s => s.IsActive == true);
        }

        public int ActivateAddressType(int ID)
        {
            AddressType toActivate = _dbContext.AddressTypes.Where(s => s.AddressTypeId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivateAddressType(int ID)
        {
            AddressType toDeactivate = _dbContext.AddressTypes.Where(s => s.AddressTypeId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public bool IsAddressTypeExist(AddressType AddressType)
        {
            AddressType checkAddressType = _dbContext.AddressTypes.Where(s => s.AddressTypeName == AddressType.AddressTypeName).FirstOrDefault();
            return (checkAddressType != null);
        }
    }
}