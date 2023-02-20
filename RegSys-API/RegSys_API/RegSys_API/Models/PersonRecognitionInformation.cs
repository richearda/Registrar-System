#nullable disable

namespace ISMS_API.Models
{
    public partial class PersonRecognitionInformation
    {
        public int PersonRecognitionInformationId { get; set; }
        public int? PersonId { get; set; }
        public string NonAcademicDistinction { get; set; }
        public bool? IsActive { get; set; }

        public virtual Person Person { get; set; }
    }
}
