#nullable disable

namespace ISMS_API.Models
{
    public partial class CivilServiceForm
    {
        public int CivilServiceFormId { get; set; }
        public string FormName { get; set; }
        public string FormCode { get; set; }
        public int? FormNo { get; set; }
        public int? Revision { get; set; }
        public bool? IsActive { get; set; }
    }
}
