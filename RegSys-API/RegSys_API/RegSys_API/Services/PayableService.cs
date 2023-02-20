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
    public class PayableService : IPayableService
    {
        private RegSysDbContext _dbContext;
        private readonly IMapper _mapper;

        public PayableService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public int AddPayable(PayableDto payableDto)
        {
            var payable = _mapper.Map<Payable>(payableDto);
            _dbContext.Payables.Add(payable);
            return _dbContext.SaveChanges();
        }

        public List<int> AddPayables(PayableDto payablesDto)
        {
            List<int> ids = new List<int>();
            var student = _dbContext.Students.Where(s => s.StudentId == payablesDto.StudentId).FirstOrDefault();
            var fees = _dbContext.Fees.Where(f => payablesDto.FeeIds.Contains(f.FeeId));

            foreach (var fee in fees)
            {
                var payable = new Payable
                {
                    FeeId = fee.FeeId,
                    TermId = payablesDto.TermId,
                    SemesterId = payablesDto.SemesterId,
                    StudentId = payablesDto.StudentId,
                    PayableRefNo = payablesDto.PayableRefNo
                };
                _dbContext.Set<Payable>().Add(payable);
            }
            _dbContext.SaveChanges();
            return ids;
        }

        public int UpdatePayable(Payable payable)
        {
            _dbContext.Entry(payable).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeletePayable(int ID)
        {
            Payable toDelete = _dbContext.Payables.AsNoTracking().Where(c => c.PayableId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public List<Payable> GetPayables()
        {
            return _dbContext.Payables.ToList();
        }

        public Payable GetPayable(int payableID)
        {
            return _dbContext.Payables.Where(p => p.PayableId == payableID).FirstOrDefault();
        }

        public List<StudentPayableDetailsDto> GetStudentPayables(int Id, int termId, int semesterId)
        {
            var result = _dbContext.Payables.Where(p => p.StudentId == Id && p.TermId == termId && p.SemesterId == semesterId).ProjectTo<StudentPayableDetailsDto>(_mapper.ConfigurationProvider).ToList();
            return result;
        }
    }
}