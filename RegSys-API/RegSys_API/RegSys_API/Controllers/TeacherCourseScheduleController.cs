using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ISMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class TeacherCourseScheduleController : Controller
    {
        private readonly ITeacherCourseScheduleService _teacherCourseScheduleService;

        public TeacherCourseScheduleController(ITeacherCourseScheduleService teacherCourseScheduleService)
        {
            _teacherCourseScheduleService = teacherCourseScheduleService;
        }

        [HttpGet("Get/Subjects/Schedule")]
        public IActionResult GetCourseSchedules([FromQuery] int termId, [FromQuery] int semesterId)
        {
            var result = _teacherCourseScheduleService.GetCourseSchedules(termId, semesterId);
            return Ok(result);
        }
    }
}