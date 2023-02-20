using AutoMapper;
using AutoMapper.QueryableExtensions;
using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services
{
    public class FeeService : IFeeService
    {
        private readonly RegSysDbContext _dbcontext;
        private readonly IMapper _mapper;

        public FeeService(RegSysDbContext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }

        public int AddFee(Fee Fee)
        {
            _dbcontext.Fees.Add(Fee);
            return _dbcontext.SaveChanges();
        }

        public int UpdateFee(Fee Fee)
        {
            _dbcontext.Entry(Fee).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }

        public int DeleteFee(int ID)
        {
            Fee toDelete = _dbcontext.Fees.AsNoTracking().Where(c => c.FeeId == ID).FirstOrDefault();
            _dbcontext.Entry(toDelete).State = EntityState.Deleted;
            return _dbcontext.SaveChanges();
        }

        public List<FeeDto> GetFeeByFeeTypeName(string feeTypeName)
        {
            return _dbcontext.Fees.Where(f => f.FeeType.FeeTypeDescription == feeTypeName && f.IsActive == true).ProjectTo<FeeDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<FeeDto> GetActiveFees()
        {
            return _dbcontext.Fees.Where(f => f.IsActive == true).ProjectTo<FeeDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<FeeDto> GetInactiveFees()
        {
            return _dbcontext.Fees.Where(f => f.IsActive == false).ProjectTo<FeeDto>(_mapper.ConfigurationProvider).ToList();
        }

        public int DeactivateFee(int ID)
        {
            Fee toDeactivate = _dbcontext.Fees.AsNoTracking().Where(f => f.FeeId == ID).FirstOrDefault();
            //update IsActive
            toDeactivate.IsActive = false;
            _dbcontext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }

        public int ActivateFee(int ID)
        {
            Fee toActivate = _dbcontext.Fees.AsNoTracking().Where(f => f.FeeId == ID).FirstOrDefault();
            //update IsActive
            toActivate.IsActive = true;
            _dbcontext.Entry(toActivate).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }

        public FeeDto GetFeeByName(string feeName)
        {
            return _dbcontext.Fees.Where(f => f.FeeName == feeName).ProjectTo<FeeDto>(_mapper.ConfigurationProvider).FirstOrDefault();
        }
    }
}