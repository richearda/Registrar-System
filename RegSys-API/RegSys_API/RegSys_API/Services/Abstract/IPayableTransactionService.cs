using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IPayableTransactionService
    {

        int AddPayableTransaction(PayableTransactionDto payableTransactionDto);
        int UpdatePayableTransaction(PayableTransaction PayableTransaction);
        int DeletePayableTransaction(int payableTransactionID);
        IQueryable<PayableTransaction> GetPayableTransactiones();
        PayableTransaction GetPayableTransaction(int payableTransactionID);
        //bool IsPayableTransactionExist(PayableTransaction payableTransaction);
    }
}
