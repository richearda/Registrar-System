using AutoMapper;
using AutoMapper.QueryableExtensions;
using ISMS_API.Data;
using ISMS_API.DTOs;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services
{
    public class BlockService : IBlockService
    {
        private readonly RegSysDbContext _dbContext;
        private readonly IMapper _mapper;

        public BlockService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public int ActivateBlock(int ID)
        {
            Block toActivate = _dbContext.Blocks.AsNoTracking().Where(b => b.BlockId == ID).FirstOrDefault();
            //update IsActive
            toActivate.IsActive = true;
            _dbContext.Entry(toActivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int AddBlock(BlockDto blockDto)
        {
            Block dtoToModel = _mapper.Map<Block>(blockDto);
            _dbContext.Blocks.Add(dtoToModel);
            return _dbContext.SaveChanges();
        }

        public int DeactivateBlock(int ID)
        {
            Block toDeactivate = _dbContext.Blocks.AsNoTracking().Where(b => b.BlockId == ID).FirstOrDefault();
            //update IsActive
            toDeactivate.IsActive = false;
            _dbContext.Entry(toDeactivate).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int DeleteBlock(int blockId)
        {
            Block toDelete = _dbContext.Blocks.Where(b => b.BlockId == blockId).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public List<GetBlockDto> GetBlocks()
        {
            return _dbContext.Blocks.ProjectTo<GetBlockDto>(_mapper.ConfigurationProvider).ToList();
        }

        public int UpdateBlock(Block block)
        {
            _dbContext.Entry(block).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public GetBlockDto GetBlock(int blockId)
        {
            return _dbContext.Blocks.Where(b => b.BlockId == blockId).ProjectTo<GetBlockDto>(_mapper.ConfigurationProvider).FirstOrDefault();
        }

        public List<GetBlockDto> GetActiveBlocks()
        {
            return _dbContext.Blocks.Where(b => b.IsActive).ProjectTo<GetBlockDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<GetBlockDto> GetInactiveBlocks()
        {
            return _dbContext.Blocks.Where(b => b.IsActive == false).ProjectTo<GetBlockDto>(_mapper.ConfigurationProvider).ToList();
        }

        public IQueryable<GetBlockDto> GetCurrentBlockByProgramAndMajor(FilterCurrentBlocksByProgramAndMajorDto filterDto)
        {
            //var semId = _dbContext.Semesters.Select(s => new Semester
            //{
            //    SemesterId = s.SemesterId
            //}).Where(s => s.IsCurrent == true && s.IsActive == true).FirstOrDefault();
            //var termId = _dbContext.Terms.Select(t => new Term
            //{
            //    TermId = t.TermId
            //}).Where(t => t.IsCurrent == true && t.IsActive == true).FirstOrDefault();
            //filterDto.SemesterId = semId;
            var blocks = _dbContext.Blocks.Where(b => b.TermId == filterDto.TermId && b.SemesterId == filterDto.SemesterId);
            return blocks.Where(b => b.ProgramId == filterDto.ProgramId && b.MajorId == filterDto.MajorId).ProjectTo<GetBlockDto>(_mapper.ConfigurationProvider);
        }
    }
}