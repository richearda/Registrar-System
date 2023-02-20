using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IFeeService
    {
       // IQueryable<Fee> GetFees();
        int AddFee(Fee Fee);
        int UpdateFee(Fee Fee);
        List<FeeDto> GetActiveFees();
        List<FeeDto> GetInactiveFees();
        int ActivateFee(int ID);
        int DeactivateFee(int ID);
        int DeleteFee(int ID);
        //bool IsFeeExist(Fee Fee);
        //Fee GetFee(int ID);
        List<FeeDto> GetFeeByFeeTypeName(string feeTypeName);
        FeeDto GetFeeByName(string feeName);    
    }
}