using System.Collections.Generic;

namespace ISMS_API.Models
{
    public partial class Payable
    {
        public int PayableId { get; set; }
        public string PayableRefNo { get; set; }
        public int? FeeId { get; set; }
        public int? TermId { get; set; }
        public int? SemesterId { get; set; }
        public int? StudentId { get; set; }

        public virtual Fee Fee { get; set; }
        public virtual Term Term { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual Student Student { get; set; }
        public ICollection<PayableTransaction> PayableTransaction { get; set; }
    }
}