#nullable disable

namespace ISMS_API.Models
{
    public partial class StudentGrade
    {
        public int StudentGradesId { get; set; }
        public int? StudentScheduleId { get; set; }
        public decimal? PrelimPeriodGrade { get; set; }
        public decimal? MidtermPeriodGrade { get; set; }
        public decimal? SemiFinalPeriodGrade { get; set; }
        public decimal? FinalPeriodGrade { get; set; }
        public decimal? FinalGeneralAverage { get; set; }
        public int? GradeRemarksId { get; set; }

        public virtual GradeRemark GradeRemarks { get; set; }
        public virtual StudentCourseSchedule StudentSchedule { get; set; }
    }
}
