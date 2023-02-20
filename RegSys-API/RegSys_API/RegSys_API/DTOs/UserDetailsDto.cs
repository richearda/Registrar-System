using System.Collections.Generic;

namespace ISMS_API.DTOs
{
    public class UserDetailsDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
        public bool? IsActive { get; set; }
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        //public PersonUserDetailsDto Person { get; set; }
        //public virtual ICollection<PersonUserDto> PersonUser { get; set; }
    }
}