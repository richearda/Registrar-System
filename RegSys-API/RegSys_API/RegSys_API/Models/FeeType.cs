#nullable disable

using System.Collections.Generic;

namespace ISMS_API.Models
{
    public partial class FeeType
    {
        public int FeeTypeId { get; set; }
        public string FeeTypeDescription { get; set; }
        public bool? IsActive { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}