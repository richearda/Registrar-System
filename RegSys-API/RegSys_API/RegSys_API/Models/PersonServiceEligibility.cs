﻿using System;

#nullable disable

namespace ISMS_API.Models
{
    public partial class PersonServiceEligibility
    {
        public int PersonServiceEligibilityId { get; set; }
        public int? PersonId { get; set; }
        public string CareerEligibility { get; set; }
        public double? Rating { get; set; }
        public DateTime? ExaminationDate { get; set; }
        public string ExaminationPlace { get; set; }
        public string LicenseNo { get; set; }
        public DateTime? ValidityDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Person Person { get; set; }
    }
}
