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
    public class CourseScheduleController : Controller
    {
        private ICourseScheduleService _courseScheduleService;

        public CourseScheduleController(ICourseScheduleService courseScheduleService)
        {
            _courseScheduleService = courseScheduleService;
        }
        [HttpGet(Routes.GetList)]
        public IActionResult GetCourseSchedules()
        {
            var courseSchedules = _courseScheduleService.GetCourseSchedules();

            return Ok(courseSchedules);
        }
        [HttpGet(Routes.GetList + "/CurrentOfferedCourses")]
        public IActionResult GetCurrentOfferedSchedules()
        {
            var courseSchedules = _courseScheduleService.GetCurrentOfferedSchedules();
            return Ok(courseSchedules);
        }


    }
}
