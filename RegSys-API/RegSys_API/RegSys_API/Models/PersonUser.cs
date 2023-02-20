#nullable disable

using System.ComponentModel.DataAnnotations.Schema;

namespace ISMS_API.Models
{
    public partial class PersonUser
    {
        public int PersonUserId { get; set; }

        [ForeignKey("PersonId")]
        public int? PersonId { get; set; }

        [ForeignKey("UserId")]
        public int? UserId { get; set; }

        public virtual Person Person { get; set; }
        public virtual User User { get; set; }
    }
}