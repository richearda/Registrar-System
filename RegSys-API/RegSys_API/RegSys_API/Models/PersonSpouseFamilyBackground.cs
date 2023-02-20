#nullable disable

namespace ISMS_API.Models
{
    public partial class PersonSpouseFamilyBackground
    {
        public int PersonSpouseFamilyBackgroundId { get; set; }
        public int? PersonId { get; set; }
        public string SpouseSurname { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseMiddleName { get; set; }
        public string NameExtension { get; set; }
        public string Occupation { get; set; }
        public string EmployerOrBusinessName { get; set; }
        public string BusinessAddress { get; set; }
        public string TelephoneNo { get; set; }
        public bool? IsActive { get; set; }

        public virtual Person Person { get; set; }
    }
}
