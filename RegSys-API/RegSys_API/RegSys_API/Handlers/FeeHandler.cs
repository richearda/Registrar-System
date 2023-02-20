namespace ISMS_API.Handlers
{
    public class FeeHandler
    {
        //private IFeeService FeeService;
        //private IFeeService _FeeService;

        //public FeeHandler(IFeeService FeeService)
        //{
        //    _FeeService = FeeService;
        //}

        //public ValidationResult CanAddFee(Fee Fee)
        //{
        //    ValidationResult result = null;

        //    if (Fee.FeeDescription != null && Fee.FeeDescription != "")
        //    {
        //        if (Fee.FeeDescription != null && Fee.FeeDescription != "")
        //        {
        //            if (_FeeService.IsFeeExist(Fee))
        //                result = new ValidationResult("Fee", "Already existing", 400);
        //        }
        //        else
        //            result = new ValidationResult("FeeTypeID", "Required", 400);
        //    }
        //    else
        //        result = new ValidationResult("Fee", "Required", 400);

        //    return result;
        //}

        //public ValidationResult CanUpdateFee(Fee Fee)
        //{
        //    ValidationResult result = null;
        //    Fee origFee = _FeeService.GetFee(Fee.FeeID);

        //    if (origFee != null)
        //    {
        //        if (Fee.FeeDescription == null || Fee.FeeDescription == "")
        //            result = new ValidationResult("Fee", "Required", 400);
        //        else if (Fee.FeeDescription == null || Fee.FeeDescription == "")
        //            result = new ValidationResult("FeeTypeID", "Required", 400);
        //        else if ((Fee.FeeDescription.Equals(origFee.FeeDescription)))
        //        {
        //            if (_FeeService.IsFeeExist(Fee))
        //                result = new ValidationResult("FeeTypeID", "Already existing", 400);
        //        }
        //    }
        //    else
        //        result = new ValidationResult("Error", "Does not exist", 404);

        //    return result;
        //}

        //public ValidationResult CanCheckFee(int ID)
        //{
        //    ValidationResult result = null;
        //    Fee Fee = _FeeService.GetFee(ID);

        //    if (Fee == null)
        //        result = new ValidationResult("Error", "Does not exist", 404);

        //    return result;
        //}
    }
}