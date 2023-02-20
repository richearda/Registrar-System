using AutoMapper;
using AutoMapper.QueryableExtensions;
using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly RegSysDbContext _dbContext;
        private readonly IMapper _mapper;

        public TransactionService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public int AddTransaction(TransactionDto transaction)
        {
            var feeType = _dbContext.FeeTypes.Where(f => f.FeeTypeId == transaction.FeeTypeId).FirstOrDefault();
            var payableTrans = _mapper.Map<Transaction>(transaction);
            payableTrans.FeeTypeId = feeType.FeeTypeId;
            _dbContext.Transactions.Add(payableTrans);
            _dbContext.SaveChanges();
            return payableTrans.TransactionId;
        }

        public int DeleteTransaction(int transactionID)
        {
            Transaction toDelete = _dbContext.Transactions.Where(pt => pt.TransactionId == transactionID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public TransactionDto GetTransaction(int ID)
        {
            return _dbContext.Transactions.Where(pt => pt.TransactionId == ID).ProjectTo<TransactionDto>(_mapper.ConfigurationProvider).FirstOrDefault();
        }

        public IQueryable<Transaction> GetTransactions()
        {
            return _dbContext.Transactions;
        }

        public int UpdateTransaction(TransactionDto transaction)
        {
            var transToModify = _mapper.Map<TransactionDto, Transaction>(transaction);
            transToModify.FeeTypeId = transaction.FeeTypeId;
            _dbContext.Entry(transToModify).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public TransactionDto GetStudentCurrentTransaction(int studentID)
        {
            return _dbContext.Transactions.Where(p => p.StudentId == studentID && p.IsCurrent).ProjectTo<TransactionDto>(_mapper.ConfigurationProvider).FirstOrDefault();
        }

        public List<TransactionDto> GetStudentRemainingPayables(int studentID, int termId, int semesterId)
        {
            return _dbContext.Transactions.Where(p => p.StudentId == studentID && p.TermId == termId && p.SemesterId == semesterId && p.IsCurrent).ProjectTo<TransactionDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<TransactionDto> GetStudentTransactions(int studentID)
        {
            return _dbContext.Transactions.Where(s => s.StudentId == studentID && s.IsCurrent == false).ProjectTo<TransactionDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<TransactionDto> GetStudentMainTrans(int studentID, int termId, int semesterId)
        {
            return _dbContext.Transactions.Where(p => p.StudentId == studentID && p.TermId == termId && p.SemesterId == semesterId && p.IsMain).ProjectTo<TransactionDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<TransactionDto> GetPaymentTransHistory(string payableRefNo)
        {
            return _dbContext.Transactions.Where(p => p.PayableRefNo == payableRefNo && p.IsCurrent == false).ProjectTo<TransactionDto>(_mapper.ConfigurationProvider).ToList();
        }

        public TransactionDto GetPayableBalanceByPayableRef(string payableRefNo)
        {
            return _dbContext.Transactions.Where(p => p.PayableRefNo == payableRefNo && p.IsCurrent == true).ProjectTo<TransactionDto>(_mapper.ConfigurationProvider).FirstOrDefault();
        }
    }
}