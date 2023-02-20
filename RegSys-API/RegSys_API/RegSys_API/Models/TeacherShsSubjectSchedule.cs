#nullable disable

namespace ISMS_API.Models
{
    public partial class TeacherShsSubjectSchedule
    {
        public int TeacherShsSubjectScheduleId { get; set; }
        public int? TeacherId { get; set; }
        public int? SubjectScheduleId { get; set; }

        public virtual ShsSubjectSchedule SubjectSchedule { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
