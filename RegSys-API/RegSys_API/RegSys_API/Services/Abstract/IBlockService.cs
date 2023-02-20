using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IBlockService
    {
        int AddBlock(BlockDto blockDto);

        int UpdateBlock(Block block);

        int DeleteBlock(int blockId);

        List<GetBlockDto> GetBlocks();

        List<GetBlockDto> GetActiveBlocks();

        List<GetBlockDto> GetInactiveBlocks();

        GetBlockDto GetBlock(int blockId);

        IQueryable<GetBlockDto> GetCurrentBlockByProgramAndMajor(FilterCurrentBlocksByProgramAndMajorDto filterDto);

        int ActivateBlock(int ID);

        int DeactivateBlock(int ID);
    }
}