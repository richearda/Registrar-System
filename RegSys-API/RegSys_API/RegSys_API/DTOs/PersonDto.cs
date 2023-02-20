using System;
using System.Collections.Generic;

namespace ISMS_API.DTOs
{
    public class PersonDto
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MaidenName { get; set; }
        public string NameExtension { get; set; }

        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get; set; }
        public GenderDto Gender { get; set; }
        public CivilStatusDto CivilStatus { get; set; }
        public CitizenshipDto Citizenship { get; set; }
        public CountryDto Country { get; set; }
        public string TelephoneNo { get; set; }
        public string MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public AddressDto Address { get; set; }
    }
}
