using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class EducationLevel
    {
        public EducationLevel()
        {
            PersonEducationalBackgrounds = new HashSet<PersonEducationalBackground>();
        }

        public int EducationLevelId { get; set; }
        public string LevelName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<PersonEducationalBackground> PersonEducationalBackgrounds { get; set; }
    }
}
