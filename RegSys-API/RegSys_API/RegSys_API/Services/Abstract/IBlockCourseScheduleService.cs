using ISMS_API.DTOs;
using ISMS_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Services.Abstract
{
    public interface IBlockCourseScheduleService
    {
        int AddBlockCourseSchedules(AddBlockCourseScheduleDto blockCourseScheduleDto);

        int UpdateBlockCourseSchedule(BlockCourseSchedule blockCourseSchedule);

        int DeleteBlockCourseSchedule(int ID);

        List<BlockCourseScheduleDto> GetBlockCourseSchedules();

        List<GetBlockCoursesDto> GetBlockCourseSchedules(int ID);

        List<CourseScheduleDto> GetCourseScheduleNotInBlock(int[] Ids);

        BlockCourseScheduleDto GetBlockCourseSchedule(int ID);

        //int ActivateBlockCourseSchedule(int blockId);

        //int DeactivateBlockCourseSchedule(int blockId);
    }
}