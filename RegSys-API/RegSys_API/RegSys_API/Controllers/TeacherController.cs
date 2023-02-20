using ISMS_API.Helpers;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ISMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class TeacherController : Controller
    {
        private ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [HttpGet(Routes.GetList + "/Teachers")]
        public IActionResult GetTeachers()
        {
            var result = _teacherService.GetTeachers();
            return Ok(result);
        }
    }
}
