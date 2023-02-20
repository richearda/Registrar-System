#nullable disable

namespace ISMS_API.Models
{
    public partial class PersonReference
    {
        public int PersonReferenceId { get; set; }
        public int? PersonId { get; set; }
        public string PersonReferenceName { get; set; }
        public string PersonReferenceAddress { get; set; }
        public string ContactNo { get; set; }
        public bool? IsActive { get; set; }

        public virtual Person Person { get; set; }
    }
}
