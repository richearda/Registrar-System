using ISMS_API.Data;

namespace ISMS_API.Services
{
    public class TuitionFeeRateService //: ITuitionFeeRateService
    {
        private RegSysDbContext _dbcontext;

        public TuitionFeeRateService(RegSysDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        /*public int AddTuitionFeeRate(TuitionFeeRate TuitionFeeRate)
        {
            _dbcontext.TuitionFeeRates.Add(TuitionFeeRate);
            return _dbcontext.SaveChanges();
        }

        public int DeactivateTuitionFeeRate(int ID)
        {
            TuitionFeeRate toDeactivate = _dbcontext.TuitionFeeRates.AsNoTracking().Where(c => c.TuitionFeeRateID == ID).FirstOrDefault();
            //update IsActive
            toDeactivate.IsActive = false;
            _dbcontext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }

        public int ActivateTuitionFeeRate(int ID)
        {
            TuitionFeeRate toActivate = _dbcontext.TuitionFeeRates.AsNoTracking().Where(c => c.TuitionFeeRateID == ID).FirstOrDefault();
            //update IsActive
            toActivate.IsActive = true;
            _dbcontext.Entry(toActivate).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }

        public int DeleteTuitionFeeRate(int ID)
        {
            TuitionFeeRate toDelete = _dbcontext.TuitionFeeRates.AsNoTracking().Where(c => c.TuitionFeeRateID == ID).FirstOrDefault();
            _dbcontext.Entry(toDelete).State = EntityState.Deleted;
            return _dbcontext.SaveChanges();
        }

        public TuitionFeeRate GetTuitionFeeRate(int ID)
        {
            return _dbcontext.TuitionFeeRates.AsNoTracking().Where(c => c.TuitionFeeRateID == ID).FirstOrDefault();
        }

        public IQueryable<TuitionFeeRate> GetTuitionFeeRates()
        {
            return _dbcontext.TuitionFeeRates.Where(c => c.IsActive == true);
        }

        public bool IsTuitionFeeRateExist(TuitionFeeRate TuitionFeeRate)
        {
            TuitionFeeRate toCheck = _dbcontext.TuitionFeeRates.Where(c => c.TuitionFeeRateID == TuitionFeeRate.TuitionFeeRateAmount).FirstOrDefault();
            return (toCheck != null);
        }

        public int UpdateTuitionFeeRate(TuitionFeeRate TuitionFeeRate)
        {
            _dbcontext.Entry(TuitionFeeRate).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }*/
    }
}