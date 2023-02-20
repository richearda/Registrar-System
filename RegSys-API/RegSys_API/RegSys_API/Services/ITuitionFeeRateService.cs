using ISMS_API.Models;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface ITuitionFeeRateService
    {
        IQueryable<TuitionFeeRate> GetTuitionFeeRates();
        int AddTuitionFeeRate(TuitionFeeRate TuitionFeeRate);
        int UpdateTuitionFeeRate(TuitionFeeRate TuitionFeeRate);
        int ActivateTuitionFeeRate(int ID);
        int DeactivateTuitionFeeRate(int ID);
        int DeleteTuitionFeeRate(int ID);
        bool IsTuitionFeeRateExist(TuitionFeeRate TuitionFeeRate);
        TuitionFeeRate GetTuitionFeeRate(int ID);
    }
}