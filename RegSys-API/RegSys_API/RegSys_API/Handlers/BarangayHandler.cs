using ISMS_API.Services.Abstract;

namespace ISMS_API.Handlers
{
    public class BarangayHandler
    {
        private IBarangayService _barangayService;
        public BarangayHandler(IBarangayService barangayService)
        {
            _barangayService = barangayService;
        }

        /*public ValidationResult CanAddBarangay(Barangay barangay)
        {
            ValidationResult result = null;

            if (barangay.BarangayName != null || barangay.BarangayName != "")
            {
                bool isExist = _barangayService.IsBarangayExist(barangay);
                if (isExist)
                {
                    result = new ValidationResult("Barangay Name", "Already existing", 400);
                }             
            }
            else
                result = new ValidationResult("Barangay Name", "Required", 400);

            return result;
        }

        public ValidationResult CanUpdateBarangay(Barangay barangay)
        {
            ValidationResult result = null;
            Barangay updateBarangay = _barangayService.GetBarangay(barangay.BarangayId);

            if (updateBarangay != null)
            {
                if (barangay.BarangayName == null || barangay.BarangayName == "")
                    result = new ValidationResult("Barangay Name", "Required", 400);              
                else if ((barangay.BarangayName.Equals(updateBarangay.BarangayName, StringComparison.OrdinalIgnoreCase)))
                {              
                        result = new ValidationResult("Please provide different value.", "Cannot update with the same value.", 400);
                }
            }
            else
                result = new ValidationResult("Error", "Does not exist", 404);

            return result;
        }

        public ValidationResult CanCheckBarangay(int barangayId)
        {
            ValidationResult result = null;
            Barangay barangay = _barangayService.GetBarangay(barangayId);

            if (barangay == null)
                result = new ValidationResult("Error", "Does not exist", 404);
            return result;
        }
        */


    }
}
