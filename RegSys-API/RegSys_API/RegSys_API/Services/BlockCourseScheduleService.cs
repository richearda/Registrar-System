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
    public class BlockCourseScheduleService : IBlockCourseScheduleService
    {
        private readonly RegSysDbContext _dbContext;
        private readonly IMapper _mapper;

        public BlockCourseScheduleService(RegSysDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        //public int ActivateBlockCourseSchedule(int blockId)
        //{
        //    BlockCourseSchedule toActivate = _dbContext.BlockCourseSchedules.AsNoTracking().Where(b => b.BlockId == blockId).FirstOrDefault();
        //    //update IsActive
        //    toActivate.IsActive = true;
        //    _dbContext.Entry(toActivate).State = EntityState.Modified;
        //    return _dbContext.SaveChanges();
        //}

        public int AddBlockCourseSchedules(AddBlockCourseScheduleDto blockCourseScheduleDto)
        {
            var courseSchedules = _dbContext.CourseSchedules.Where(c => blockCourseScheduleDto.CourseScheduleIds.Contains(c.CourseScheduleId));
            foreach (var courseSchedule in courseSchedules)
            {
                var blockCourseSched = new BlockCourseSchedule
                {
                    BlockId = blockCourseScheduleDto.BlockId,
                    CourseScheduleId = courseSchedule.CourseScheduleId,
                };
                _dbContext.BlockCourseSchedules.Add(blockCourseSched);
            }
            return _dbContext.SaveChanges();
        }

        //public int DeactivateBlockCourseSchedule(int blockId)
        //{
        //    throw new System.NotImplementedException();
        //}

        public int DeleteBlockCourseSchedule(int ID)
        {
            BlockCourseSchedule toDelete = _dbContext.BlockCourseSchedules.Where(b => b.BlockCourseScheduleId == ID).FirstOrDefault();
            _dbContext.Entry(toDelete).State = EntityState.Deleted;
            return _dbContext.SaveChanges();
        }

        public BlockCourseScheduleDto GetBlockCourseSchedule(int ID)
        {
            return _dbContext.BlockCourseSchedules.Where(b => b.BlockCourseScheduleId == ID).ProjectTo<BlockCourseScheduleDto>(_mapper.ConfigurationProvider).FirstOrDefault();
        }

        public List<BlockCourseScheduleDto> GetBlockCourseSchedules()
        {
            return _dbContext.BlockCourseSchedules.ProjectTo<BlockCourseScheduleDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<GetBlockCoursesDto> GetBlockCourseSchedules(int ID)
        {
            return _dbContext.BlockCourseSchedules.Where(b => b.BlockId == ID).ProjectTo<GetBlockCoursesDto>(_mapper.ConfigurationProvider).ToList();
        }

        public List<CourseScheduleDto> GetCourseScheduleNotInBlock(int[] Ids)
        {
            return _dbContext.CourseSchedules.Where(c => c.CourseScheduleId != 0 && (!Ids.Contains((int)c.CourseScheduleId))).ProjectTo<CourseScheduleDto>(_mapper.ConfigurationProvider).ToList();
        }

        public int UpdateBlockCourseSchedule(BlockCourseSchedule blockCourseSchedule)
        {
            _dbContext.Entry(blockCourseSchedule).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }
    }
}