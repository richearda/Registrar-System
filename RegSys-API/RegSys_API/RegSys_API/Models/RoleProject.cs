#nullable disable

namespace ISMS_API.Models
{
    public partial class RoleProject
    {
        public int RoleProjectId { get; set; }
        public int? RoleId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
        public virtual Role Role { get; set; }
    }
}
