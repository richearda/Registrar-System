using AutoMapper;
using AutoMapper.QueryableExtensions;
using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services
{
    public class FeeTypeService : IFeeTypeService
    {
        private RegSysDbContext _dbContext;
        private readonly IMapper _mapper;

        public FeeTypeService(RegSysDbContext dbcontext, IMapper mapper)
        {
            _dbContext = dbcontext;
            _mapper = mapper;
        }

        public List<FeeTypeDto> GetFeeTypes()
        {
            return _dbContext.FeeTypes.ProjectTo<FeeTypeDto>(_mapper.ConfigurationProvider).ToList();
        }

        public int AddFeeType(FeeTypeDto feeTypeDto)
        {
            var dtoToModel = _mapper.Map<FeeTypeDto, FeeType>(feeTypeDto);
            _dbContext.FeeTypes.Add(dtoToModel);
            return _dbContext.SaveChanges();
        }

        public int UpdateFeeType(FeeTypeDto feeTypeDto)
        {
            var dtoToModel = _mapper.Map<FeeTypeDto, FeeType>(feeTypeDto);
            _dbContext.Entry(dtoToModel).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeactivateFeeType(int ID)
        {
            FeeType toDeactivate = _dbContext.FeeTypes.AsNoTracking().Where(c => c.FeeTypeId == ID).FirstOrDefault();
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int ActivateFeeType(int ID)
        {
            FeeType toActivate = _dbContext.FeeTypes.AsNoTracking().Where(c => c.FeeTypeId == ID).FirstOrDefault();
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteFeeType(int ID)
        {
            FeeType toDelete = _dbContext.FeeTypes.AsNoTracking().Where(c => c.FeeTypeId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public FeeType GetFeeType(int ID)
        {
            return _dbContext.FeeTypes.AsNoTracking().Where(c => c.FeeTypeId == ID).FirstOrDefault();
        }

        public List<FeeTypeDto> GetActiveFeeTypes()
        {
            return _dbContext.FeeTypes.AsNoTracking().Where(f => f.IsActive == true).ProjectTo<FeeTypeDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<FeeTypeDto> GetInactiveFeeTypes()
        {
            return _dbContext.FeeTypes.AsNoTracking().Where(f => f.IsActive == false).ProjectTo<FeeTypeDto>(_mapper.ConfigurationProvider).ToList();
        }

        /*public IQueryable<FeeType> GetFeeTypes()
        {
            return _dbContext.FeeTypes.Where(c => c.IsActive == true);
        }

        public bool IsFeeTypeExist(FeeType FeeType)
        {
            FeeType toCheck = _dbContext.FeeTypes.Where(c => c.FeeTypeDescription == FeeType.FeeTypeDescription).FirstOrDefault();
            return (toCheck != null);
        }

        */
    }
}