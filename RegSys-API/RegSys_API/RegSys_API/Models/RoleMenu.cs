﻿#nullable disable

namespace ISMS_API.Models
{
    public partial class RoleMenu
    {
        public int RoleMenuId { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual Role Role { get; set; }
    }
}
