#nullable disable

namespace ISMS_API.Models
{
    public partial class PersonSkillsInformation
    {
        public int PersonSkillsInformationId { get; set; }
        public int? PersonId { get; set; }
        public string SkillsHobbies { get; set; }
        public bool? IsActive { get; set; }

        public virtual Person Person { get; set; }
    }
}
