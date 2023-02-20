﻿using System;

#nullable disable

namespace ISMS_API.Models
{
    public partial class PersonTrainingProgram
    {
        public int PersonTrainingProgramId { get; set; }
        public int? PersonId { get; set; }
        public string TrainingProgramTitle { get; set; }
        public DateTime? InclusiveDateFrom { get; set; }
        public DateTime? InclusiveDateTo { get; set; }
        public double? NoOfHours { get; set; }
        public int? TrainingProgramTypeId { get; set; }
        public string TrainingProgramSponsor { get; set; }
        public bool? IsActive { get; set; }

        public virtual Person Person { get; set; }
        public virtual TrainingProgramType TrainingProgramType { get; set; }
    }
}
