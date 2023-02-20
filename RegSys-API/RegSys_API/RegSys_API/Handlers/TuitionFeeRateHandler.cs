namespace ISMS_API.Handlers
{
    public class TuitionFeeRateHandler
    {
        //private ITuitionFeeRateService _TuitionFeeRateService;

        //public TuitionFeeRateHandler(ITuitionFeeRateService TuitionFeeRateService)
        //{
        //    _TuitionFeeRateService = TuitionFeeRateService;
        //}

        //public ValidationResult CanAddTuitionFeeRate(TuitionFeeRate TuitionFeeRate)
        //{
        //    ValidationResult result = null;

        //    if (TuitionFeeRate.Tuition != null && TuitionFeeRate.Tuition != "")
        //    {
        //        if (TuitionFeeRate.Tuition != null && TuitionFeeRate.Tuition != "")
        //        {
        //            if (_TuitionFeeRateService.IsTuitionFeeRateExist(TuitionFeeRate))
        //                result = new ValidationResult("TuitionFeeRateAmount", "Already existing", 400);
        //        }
        //        else
        //            result = new ValidationResult("Tuition", "Required", 400);
        //    }
        //    else
        //        result = new ValidationResult("TuitionFeeRateAmount", "Required", 400);

        //    return result;
        //}

        //public ValidationResult CanUpdateTuitionFeeRate(TuitionFeeRate TuitionFeeRate)
        //{
        //    ValidationResult result = null;
        //    TuitionFeeRate origTuitionFeeRate = _TuitionFeeRateService.GetTuitionFeeRate(TuitionFeeRate.TuitionFeeRateID);

        //    if (origTuitionFeeRate != null)
        //    {
        //        if (TuitionFeeRate == null || TuitionFeeRate.Tuition == "")
        //            result = new ValidationResult("TuitionFeeRateAmount", "Required", 400);
        //        else if (TuitionFeeRate.Tuition == null || TuitionFeeRate.Tuition == "")
        //            result = new ValidationResult("Tuition", "Required", 400);
        //        else if ((TuitionFeeRate.TuitionFeeRateAmount.Equals(origTuitionFeeRate.TuitionFeeRateAmount)))
        //        {
        //            if (_TuitionFeeRateService.IsTuitionFeeRateExist(TuitionFeeRate))
        //                result = new ValidationResult("TuitionFeeRateAmount", "Already existing", 400);
        //        }
        //    }
        //    else
        //        result = new ValidationResult("Error", "Does not exist", 404);

        //    return result;
        //}

        //public ValidationResult CanCheckTuitionFeeRate(int ID)
        //{
        //    ValidationResult result = null;
        //    TuitionFeeRate TuitionFeeRate = _TuitionFeeRateService.GetTuitionFeeRate(ID);

        //    if (TuitionFeeRate == null)
        //        result = new ValidationResult("Error", "Does not exist", 404);

        //    return result;
        //}
    }
}