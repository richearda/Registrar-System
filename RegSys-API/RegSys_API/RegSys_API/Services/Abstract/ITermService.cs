using ISMS_API.DTOs;
using ISMS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Services.Abstract
{
    public interface ITermService
    {
        Term GetTermByName(string termName);
        TermDto GetCurrentActiveTerm();
        List<TermDto> GetTerms();
    }
}
