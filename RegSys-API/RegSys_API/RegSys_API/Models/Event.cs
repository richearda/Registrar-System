using System;

#nullable disable

namespace ISMS_API.Models
{
    public partial class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string ThemeColor { get; set; }
        public bool? IsHoliday { get; set; }
    }
}
