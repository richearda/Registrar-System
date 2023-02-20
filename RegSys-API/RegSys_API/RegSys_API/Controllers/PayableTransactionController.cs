using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ISMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PayableTransactionController : ControllerBase
    {
        private readonly IPayableTransactionService _payableTransactionService;

        public PayableTransactionController(IPayableTransactionService payableTransactionService)
        {
            _payableTransactionService = payableTransactionService;
        }
        // GET: api/<PayableTransactionController>
        [HttpGet(Routes.GetList)]
        public IActionResult GetPayableTransactions()
        {
            var result = _payableTransactionService.GetPayableTransactiones();
            return Ok(result);
        }

        // GET api/<PayableTransactionController>/5
        [HttpGet(Routes.Get)]
        public IActionResult GetPayableTransaction(int id)
        {
            var result = _payableTransactionService.GetPayableTransaction(id);
            return Ok(result);
        }

        // POST api/<PayableTransactionController>
        [HttpPost(Routes.Add)]
        public IActionResult AddPayableTransaction([FromBody] PayableTransactionDto payableTransactionDto)
        {
            var result = _payableTransactionService.AddPayableTransaction(payableTransactionDto);
            return Ok(result);
        }

        // PUT api/<PayableTransactionController>/5
        [HttpPut(Routes.Edit)]
        public IActionResult UpdatePayableTransaction([FromBody] PayableTransaction payableTransaction)
        {
            var result = _payableTransactionService.UpdatePayableTransaction(payableTransaction);
            return Ok(result);
        }

        // DELETE api/<PayableTransactionController>/5
        [HttpDelete(Routes.Delete)]
        public IActionResult DeletePayableTransaction(int id)
        {
            var result = _payableTransactionService.DeletePayableTransaction(id);
            return Ok(result);
        }
    }
}
