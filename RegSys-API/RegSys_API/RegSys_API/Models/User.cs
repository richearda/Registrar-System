using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ISMS_API.Models
{
    public partial class User
    {
        public User()
        {
            PersonUsers = new HashSet<PersonUser>();
        }

        [Key]
        public int UserId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<PersonUser> PersonUsers { get; set; }
    }
}