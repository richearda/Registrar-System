using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Project
    {
        public Project()
        {
            RoleProjects = new HashSet<RoleProject>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string FullProjectName { get; set; }
        public string ProjectCodeName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<RoleProject> RoleProjects { get; set; }
    }
}
