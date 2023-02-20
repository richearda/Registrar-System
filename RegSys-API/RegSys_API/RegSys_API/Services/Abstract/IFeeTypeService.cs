using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IFeeTypeService
    {
        List<FeeTypeDto> GetFeeTypes();
        int AddFeeType(FeeTypeDto FeeType);
        int UpdateFeeType(FeeTypeDto FeeType);
        int ActivateFeeType(int ID);
        int DeactivateFeeType(int ID);
        int DeleteFeeType(int ID);
        List<FeeTypeDto> GetActiveFeeTypes();
        List<FeeTypeDto> GetInactiveFeeTypes();
        //bool IsFeeTypeExist(FeeType FeeType);
        //FeeType GetFeeType(int ID);

    }
}