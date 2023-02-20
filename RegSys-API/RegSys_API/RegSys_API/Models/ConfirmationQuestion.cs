using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class ConfirmationQuestion
    {
        public ConfirmationQuestion()
        {
            InverseParentQuestion = new HashSet<ConfirmationQuestion>();
            PersonConfirmationQuestions = new HashSet<PersonConfirmationQuestion>();
        }

        public int ConfirmationQuestionId { get; set; }
        public int? ParentQuestionId { get; set; }
        public int? QuestionNo { get; set; }
        public string QuestionDetails { get; set; }
        public bool? IsActive { get; set; }

        public virtual ConfirmationQuestion ParentQuestion { get; set; }
        public virtual ICollection<ConfirmationQuestion> InverseParentQuestion { get; set; }
        public virtual ICollection<PersonConfirmationQuestion> PersonConfirmationQuestions { get; set; }
    }
}
