#nullable disable

namespace ISMS_API.Models
{
    public partial class Dean
    {
        public int DeanId { get; set; }
        public int? PersonId { get; set; }
        public int? CollegeId { get; set; }
        public bool? IsActive { get; set; }

        public virtual College College { get; set; }
        public virtual Person Person { get; set; }
    }
}
