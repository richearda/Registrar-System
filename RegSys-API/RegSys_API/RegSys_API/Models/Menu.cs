using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Menu
    {
        public Menu()
        {
            InverseParentMenu = new HashSet<Menu>();
            RoleMenus = new HashSet<RoleMenu>();
        }

        public int MenuId { get; set; }
        public int? OrderNo { get; set; }
        public int? ParentMenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuLink { get; set; }
        public string MenuIcon { get; set; }
        public bool? IsActive { get; set; }

        public virtual Menu ParentMenu { get; set; }
        public virtual ICollection<Menu> InverseParentMenu { get; set; }
        public virtual ICollection<RoleMenu> RoleMenus { get; set; }
    }
}
