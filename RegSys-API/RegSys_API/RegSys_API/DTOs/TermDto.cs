﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.DTOs
{
    public class TermDto
    {
        public int TermId { get; set; }
        public string TermName { get; set; }
        public string TermCode { get; set; }
        public bool? IsCurrent { get; set; }
        public bool? IsActive { get; set; }
    }
}
