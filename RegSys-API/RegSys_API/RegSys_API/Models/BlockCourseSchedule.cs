using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISMS_API.Models
{
    [Table("BlockCourseSchedule", Schema = "dbo")]
    public class BlockCourseSchedule
    {
        public int BlockCourseScheduleId { get; set; }
        public int BlockId { get; set; }
        public int CourseScheduleId { get; set; }
        public Block Blocks { get; set; }
        public CourseSchedule CourseSchedules { get; set; }
    }
}