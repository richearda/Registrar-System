using System.Collections.Generic;

#nullable disable

namespace ISMS_API.Models
{
    public partial class RoomType
    {
        public RoomType()
        {
            Rooms = new HashSet<Room>();
        }

        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomTypeDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
