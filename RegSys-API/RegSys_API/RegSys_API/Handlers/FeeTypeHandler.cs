namespace ISMS_API.Handlers
{
    public class FeeTypeHandler
    {
        //private IFeeTypeService _FeeTypeService;

        //public FeeTypeHandler(IFeeTypeService FeeTypeService)
        //{
        //    _FeeTypeService = FeeTypeService;
        //}

        //public ValidationResult CanAddFeeType(FeeType FeeType)
        //{
        //    ValidationResult result = null;

        //    if (FeeType.FeeTypeDescription != null && FeeType.FeeTypeDescription != "")
        //    {
        //        if (FeeType.FeeTypeDescription != null && FeeType.FeeTypeDescription != "")
        //        {
        //            if (_FeeTypeService.IsFeeTypeExist(FeeType))
        //                result = new ValidationResult("FeeTypeDescription", "Already existing", 400);
        //        }
        //        else
        //            result = new ValidationResult("FeeType", "Required", 400);
        //    }
        //    else
        //        result = new ValidationResult("FeeTypeDescription", "Required", 400);

        //    return result;
        //}

        //public ValidationResult CanUpdateFeeType(FeeType FeeType)
        //{
        //    ValidationResult result = null;
        //    FeeType origFeeType = _FeeTypeService.GetFeeType(FeeType.FeeTypeID);

        //    if (origFeeType != null)
        //    {
        //        if (FeeType.FeeTypeDescription == null || FeeType.FeeTypeDescription == "")
        //            result = new ValidationResult("FeeTypeDescription", "Required", 400);
        //        else if (FeeType.FeeTypeDescription == null || FeeType.FeeTypeDescription == "")
        //            result = new ValidationResult("FeeType", "Required", 400);
        //        else if ((FeeType.FeeTypeDescription.Equals(origFeeType.FeeTypeDescription)))
        //        {
        //            if (_FeeTypeService.IsFeeTypeExist(FeeType))
        //                result = new ValidationResult("FeeTypeDescription", "Already existing", 400);
        //        }
        //    }
        //    else
        //        result = new ValidationResult("Error", "Does not exist", 404);

        //    return result;
        //}

        //public ValidationResult CanCheckFeeType(int ID)
        //{
        //    ValidationResult result = null;
        //    FeeType FeeType = _FeeTypeService.GetFeeType(ID);

        //    if (FeeType == null)
        //        result = new ValidationResult("Error", "Does not exist", 404);

        //    return result;
        //}
    }
}