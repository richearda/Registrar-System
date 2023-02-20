using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IPayableService
    {
        int AddPayable(PayableDto payableDto);

        int UpdatePayable(Payable payable);

        int DeletePayable(int payableID);

        List<Payable> GetPayables();

        Payable GetPayable(int payableID);

        List<int> AddPayables(PayableDto payables);

        List<StudentPayableDetailsDto> GetStudentPayables(int Id, int termId, int semesterId);
    }
}