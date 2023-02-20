using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Role
    {
        public Role()
        {
            RoleMenus = new HashSet<RoleMenu>();
            RoleProjects = new HashSet<RoleProject>();
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<RoleMenu> RoleMenus { get; set; }
        public virtual ICollection<RoleProject> RoleProjects { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}