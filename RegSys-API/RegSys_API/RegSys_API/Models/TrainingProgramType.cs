using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class TrainingProgramType
    {
        public TrainingProgramType()
        {
            PersonTrainingPrograms = new HashSet<PersonTrainingProgram>();
        }

        public int TrainingProgramTypeId { get; set; }
        public string TrainingProgramTypeName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<PersonTrainingProgram> PersonTrainingPrograms { get; set; }
    }
}
