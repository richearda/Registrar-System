using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ISMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CourseTypeController : Controller
    {
        private ICourseTypeService _courseTypeService;
        public CourseTypeController(ICourseTypeService courseTypeService)
        {
            _courseTypeService = courseTypeService;
        }
    
    }
}
