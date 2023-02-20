using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface ITransactionService
    {
        int AddTransaction(TransactionDto transaction);

        int UpdateTransaction(TransactionDto transaction);

        int DeleteTransaction(int transactionID);

        IQueryable<Transaction> GetTransactions();

        TransactionDto GetTransaction(int ID);

        TransactionDto GetStudentCurrentTransaction(int studentID);

        List<TransactionDto> GetStudentTransactions(int studentID);

        List<TransactionDto> GetStudentRemainingPayables(int studentID, int termId, int semesterId);

        List<TransactionDto> GetStudentMainTrans(int studentID, int termId, int semesterId);

        List<TransactionDto> GetPaymentTransHistory(string payableRef);

        TransactionDto GetPayableBalanceByPayableRef(string payableRefNo);
    }
}