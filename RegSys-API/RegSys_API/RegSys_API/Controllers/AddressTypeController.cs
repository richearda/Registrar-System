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
    public class AddressTypeController : Controller
    {
        private IAddressTypeService _addressTypeService;

        public AddressTypeController(IAddressTypeService addressTypeService)
        {
            _addressTypeService = addressTypeService;
        }

        [HttpGet("addresstypebyname")]
        public IActionResult GetAddressTypeByName(string addressTypeName)
        {
            var result = _addressTypeService.GetAddressTypeByName(addressTypeName);
            return Ok(result);
        }
    }
}
