using System;

namespace ISMS_API.Helpers
{
    public static class AgeCalculator
    {
        public static int GetAge(DateTime birthdate)
        {
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - birthdate.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
