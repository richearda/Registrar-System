using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ISMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class BlockController : Controller
    {
        private readonly IBlockService _blockService;

        public BlockController(IBlockService blockService)
        {
            _blockService = blockService;
        }

        [HttpPut(Routes.Activate)]
        public IActionResult ActivateBlock(int ID)
        {
            var result = _blockService.ActivateBlock(ID);
            return Ok(result);
        }

        [HttpPost(Routes.Add)]
        public IActionResult AddBlock([FromBody] BlockDto blockDto)
        {
            var result = _blockService.AddBlock(blockDto);
            return Ok(result);
        }

        [HttpPut(Routes.Deactivate)]
        public IActionResult DeactivateBlock(int ID)
        {
            var result = _blockService.DeactivateBlock(ID);
            return Ok(result);
        }

        [HttpDelete(Routes.Delete)]
        public IActionResult DeleteBlock([FromQuery] int blockId)
        {
            var result = _blockService.DeleteBlock(blockId);
            return Ok(result);
        }

        [HttpGet(Routes.GetList)]
        public IActionResult GetBlocks()
        {
            var result = _blockService.GetBlocks();
            return Ok(result);
        }

        [HttpPut(Routes.Edit)]
        public IActionResult UpdateBlock(Block block)
        {
            var result = _blockService.UpdateBlock(block);
            return Ok(result);
        }

        [HttpGet(Routes.Get)]
        public IActionResult GetBlock(int ID)
        {
            var result = _blockService.GetBlock(ID);
            return Ok(result);
        }

        [HttpGet(Routes.GetActiveList)]
        public IActionResult GetActiveBlocks()
        {
            var result = _blockService.GetActiveBlocks();
            return Ok(result);
        }

        [HttpGet(Routes.GetInactiveList)]
        public IActionResult GetInactiveBlocks()
        {
            var result = _blockService.GetInactiveBlocks();
            return Ok(result);
        }

        [HttpGet(Routes.GetList + "/Program/Major/Blocks")]
        public IActionResult GetCurrentBlockByProgramAndMajor([FromQuery] FilterCurrentBlocksByProgramAndMajorDto filterDto)
        {
            var result = _blockService.GetCurrentBlockByProgramAndMajor(filterDto);
            return Ok(result);
        }
    }
}