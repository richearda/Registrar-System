using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TransactionController : ControllerBase
    {
        private ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost(Routes.Add)]
        public IActionResult Addtransaction([FromBody] TransactionDto transaction)
        {
            var result = _transactionService.AddTransaction(transaction);
            return Ok(result);
        }

        [HttpPut(Routes.Edit)]
        public IActionResult Updatetransaction([FromBody] TransactionDto transaction)
        {
            var result = _transactionService.UpdateTransaction(transaction);
            return Ok(result);
        }

        [HttpDelete(Routes.Delete)]
        public IActionResult Deletetransaction(int transactionId)
        {
            var result = _transactionService.DeleteTransaction(transactionId);
            return Ok(result);
        }

        [HttpGet(Routes.Get)]
        public IActionResult Gettransaction(int id)
        {
            var result = _transactionService.GetTransaction(id);
            return Ok(result);
        }

        [HttpGet("CurrentTransaction")]
        public IActionResult GetStudentCurrenttransaction(int studentID)
        {
            var result = _transactionService.GetStudentCurrentTransaction(studentID);
            return Ok(result);
        }

        [HttpGet(Routes.GetList)]
        public IQueryable<IActionResult> Gettransactions()
        {
            var result = _transactionService.GetTransactions();
            return (IQueryable<IActionResult>)Ok(result);
        }

        [HttpGet(Routes.GetList + "/StudentTransactionHistory")]
        public IActionResult GetStudentTransactions(int studentID)
        {
            var result = _transactionService.GetStudentTransactions(studentID);
            return Ok(result);
        }

        [HttpGet("student/active/balances")]
        public IActionResult GetStudentRemainingPayables(int studentID, int termID, int semesterID)
        {
            var result = _transactionService.GetStudentRemainingPayables(studentID, termID, semesterID);
            return Ok(result);
        }

        [HttpGet("main/trans")]
        public IActionResult GetStudentMainTrans(int studentID, int termId, int semesterId)
        {
            var result = _transactionService.GetStudentMainTrans(studentID, termId, semesterId);
            return Ok(result);
        }

        [HttpGet("paymenttransactionhistory")]
        public IActionResult GetPaymentTransHistory(string payableRefNo)
        {
            var result = _transactionService.GetPaymentTransHistory(payableRefNo);
            return Ok(result);
        }

        [HttpGet("payablebalance")]
        public IActionResult GetPayableBalanceByPayableRef(string payableRefNo)

        {
            var result = _transactionService.GetPayableBalanceByPayableRef(payableRefNo);
            return Ok(result);
        }
    }
}