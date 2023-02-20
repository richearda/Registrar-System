using ISMS_API.Helpers;
using ISMS_API.Models;
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
    public class ProvinceController : Controller
    {
        private IProvinceService _provinceService;

        public ProvinceController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }
        [HttpGet("provincebyname")]
        public IActionResult GetProvinceByName(string provinceName)
        {
            var result = _provinceService.GetProvinceByName(provinceName);
            return Ok(result);
        }
        [HttpGet(Routes.GetList)]
        public IActionResult GetProvinces()
        {
            var result = _provinceService.GetProvinces();
            return Ok(result);
        }
    }
}
