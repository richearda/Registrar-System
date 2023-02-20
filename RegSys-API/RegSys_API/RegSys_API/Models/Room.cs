using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Room
    {
        public Room()
        {
            CourseSchedules = new HashSet<CourseSchedule>();
        }

        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomCode { get; set; }
        public int? RoomTypeId { get; set; }
        public int? Capacity { get; set; }
        public bool? IsActive { get; set; }

        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<CourseSchedule> CourseSchedules { get; set; }
    }
}
