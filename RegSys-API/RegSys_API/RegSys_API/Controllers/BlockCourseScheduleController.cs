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
    public class BlockCourseScheduleController : ControllerBase
    {
        private readonly IBlockCourseScheduleService _blockCourseScheduleService;

        public BlockCourseScheduleController(IBlockCourseScheduleService blockCourseScheduleService)
        {
            _blockCourseScheduleService = blockCourseScheduleService;
        }

        [HttpPost(Routes.Add)]
        public IActionResult AddBlockCourseSchedules(AddBlockCourseScheduleDto blockCourseScheduleDto)
        {
            var result = _blockCourseScheduleService.AddBlockCourseSchedules(blockCourseScheduleDto);
            return Ok(result);
        }

        [HttpPut(Routes.Edit)]
        public IActionResult UpdateBlockCourseSchedule(BlockCourseSchedule blockCourseSchedule)
        {
            var result = _blockCourseScheduleService.UpdateBlockCourseSchedule(blockCourseSchedule);
            return Ok(result);
        }

        [HttpDelete(Routes.Delete)]
        public IActionResult DeleteBlockCourseSchedule(int ID)
        {
            var result = _blockCourseScheduleService.DeleteBlockCourseSchedule(ID);
            return Ok(result);
        }

        [HttpGet(Routes.Get)]
        public IActionResult GetBlockCourseSchedule(int ID)
        {
            var result = _blockCourseScheduleService.GetBlockCourseSchedule(ID);
            return Ok(result);
        }

        [HttpGet(Routes.GetList)]
        public IActionResult GetBlockCourseSchedules()
        {
            var result = _blockCourseScheduleService.GetBlockCourseSchedules();
            return Ok(result);
        }

        [HttpGet(Routes.GetList + "/CourseSchedules")]
        public IActionResult GetBlockCourseSchedules(int ID)
        {
            var result = _blockCourseScheduleService.GetBlockCourseSchedules(ID);
            return Ok(result);
        }

        [HttpGet(Routes.GetList + "/CourseNotInBlock")]
        public IActionResult GetCourseScheduleNotInBlock([FromQuery] int[] Ids)
        {
            var result = _blockCourseScheduleService.GetCourseScheduleNotInBlock(Ids);
            return Ok(result);
        }
    }
}