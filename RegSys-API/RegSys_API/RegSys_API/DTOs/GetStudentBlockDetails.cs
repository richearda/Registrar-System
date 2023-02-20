using System.Collections.Generic;

namespace ISMS_API.DTOs
{
    public class GetStudentBlockDetails
    {
        public int BlockId { get; set; }
        public string BlockName { get; set; }

        public List<BlockCoursesDto> BlockCourses { get; set; }
    }
}