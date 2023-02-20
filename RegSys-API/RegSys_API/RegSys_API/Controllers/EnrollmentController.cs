using ISMS_API.DTOs;
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
    public class EnrollmentController : Controller
    {
        private IEnrollmentService _enrollmentService;

        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpPost(Routes.Add)]
        public IActionResult AddEnrollment(EnrollmentDto enrollmentDto)
        {
            var result = _enrollmentService.AddEnrollment(enrollmentDto);
            return Ok(result);
        }
       
        [HttpGet(Routes.GetList + "/UnenrolledCourses")]
        public IActionResult GetNotEnrolledCourseSchedules([FromQuery] int[] enrolledCourseIds)
        {
            var result = _enrollmentService.GetNotEnrolledCourseSchedules(enrolledCourseIds);
            return Ok(result);
        }

        [HttpGet("EnrollmentBySchool")]
        public IActionResult GetEnrollmentDto([FromQuery] int programId, [FromQuery] int majorId, [FromQuery] int termId, [FromQuery] int semesterId)
        {
            var result = _enrollmentService.GetEnrollmentDto(programId, majorId, termId, semesterId);
            return Ok(result);
        }

        [HttpDelete(Routes.Delete)]
        public IActionResult DeleteEnrollment(int id)
        {
            var result = _enrollmentService.DeleteEnrollment(id);
            return Ok(result);
        }
    }
}