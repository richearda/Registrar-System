using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ISMS_API.Services
{
    public class PayableTransactionService : IPayableTransactionService
    {
        private readonly RegSysDbContext _dbContext;

        public PayableTransactionService(RegSysDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddPayableTransaction(PayableTransactionDto payableTransactionDto)
        {
            var transaction = _dbContext.Transactions.Where(t => t.TransactionId == payableTransactionDto.TransactionId).FirstOrDefault();
            var payables = _dbContext.Payables.Where(p => payableTransactionDto.PayableIds.Contains(p.PayableId));

            foreach (var payable in payables)
            {
                var payableTrans = new PayableTransaction
                {
                    PayableId = payable.PayableId,
                    TransactionId = transaction.TransactionId
                };
                _dbContext.PayableTransactions.Add(payableTrans);
            }

            return _dbContext.SaveChanges();
        }

        public int DeletePayableTransaction(int payableTransactionID)
        {
            PayableTransaction toDelete = _dbContext.PayableTransactions.Where(p => p.PayableTransactionId == payableTransactionID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public PayableTransaction GetPayableTransaction(int payableTransactionID)
        {
            return _dbContext.PayableTransactions.Where(p => p.PayableTransactionId == payableTransactionID).FirstOrDefault();
        }

        public IQueryable<PayableTransaction> GetPayableTransactiones()
        {
            return _dbContext.PayableTransactions;
        }

        public int UpdatePayableTransaction(PayableTransaction payableTransaction)
        {
            _dbContext.Entry(payableTransaction).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }
    }
}