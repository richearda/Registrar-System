using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class AddressController : Controller
    {
        private IAddressService _addressService;
       

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpPost("address")]
        public async Task<ActionResult<int>> AddAddress(AddressDto addressDto)
        {
             await _addressService.AddAddress(addressDto);
            return Ok(addressDto);
        }
        [HttpGet(Routes.GetList)]
        public IActionResult GetAddresses()
        {
            var result = _addressService.GetAddresses();
            return Ok(result);
        }
        [HttpGet(Routes.Get)]
        public IActionResult GetAddress(int id)
        {
            _addressService.GetAddress(id);
            return Ok();
        }
    }
}
