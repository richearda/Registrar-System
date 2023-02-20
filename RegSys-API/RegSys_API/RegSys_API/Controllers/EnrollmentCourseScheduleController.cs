using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EnrollmentCourseScheduleController : ControllerBase
    {
        private readonly IEnrollmentCourseScheduleService _enrollmentCourseScheduleService;

        public EnrollmentCourseScheduleController(IEnrollmentCourseScheduleService enrollmentCourseScheduleService)
        {
            _enrollmentCourseScheduleService = enrollmentCourseScheduleService;
        }

        [HttpPost(Routes.Add)]
        public IActionResult AddEnrollmentCourseSchedule([FromBody] AddEnrollmentCourseSchedulesDto enrollmentCourseSchedDto)
        {
            var result = _enrollmentCourseScheduleService.AddEnrollmentCourseSchedule(enrollmentCourseSchedDto);
            return Ok(result);
        }

        [HttpPut(Routes.Edit)]
        public IActionResult UpdateEnrollmentCourseSchedule(EnrollmentCourseSchedule enrollmentBlock)
        {
            var result = _enrollmentCourseScheduleService.UpdateEnrollmentCourseSchedule(enrollmentBlock);
            return Ok(result);
        }

        [HttpDelete(Routes.Delete)]
        public IActionResult DeleteEnrollmentCourseSchedule(int id)
        {
            var result = _enrollmentCourseScheduleService.DeleteEnrollmentCourseSchedule(id);
            return Ok(result);
        }

        [HttpGet("List/CourseSchedules/{ID}")]
        public IActionResult GetEnrollmentCourseSchedule(int ID)
        {
            var result = _enrollmentCourseScheduleService.GetEnrollmentCourseSchedule(ID);
            return Ok(result);
        }

        [HttpGet("Student/{ID}")]
        public IActionResult GetEnrollmentCourseScheduleByStudentId(int ID)
        {
            var result = _enrollmentCourseScheduleService.GetEnrollmentCourseScheduleByStudentId(ID);
            return Ok(result);
        }

        [HttpGet(Routes.GetList)]
        public IActionResult GetEnrollmentCourseSchedules()
        {
            var result = _enrollmentCourseScheduleService.GetEnrollmentCourseSchedules();
            return Ok(result);
        }

        [HttpGet("Subject/StudentList")]
        public IActionResult GetStudentInSubject([FromQuery] int termId, [FromQuery] int semesterId, [FromQuery] int courseSchedId)
        {
            var result = _enrollmentCourseScheduleService.GetStudentInSubject(termId, semesterId, courseSchedId);
            return Ok(result);
        }

        [HttpGet("Student/SubjectList")]
        public IActionResult GetStudentSubjectList([FromQuery] int termId, [FromQuery] int semesterId, [FromQuery] int studentId)
        {
            var result = _enrollmentCourseScheduleService.GetStudentSubjectList(termId, semesterId, studentId);
            return Ok(result);
        }
    }
}