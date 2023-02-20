namespace ISMS_API.DTOs
{
    public class FilterCurrentBlocksByProgramAndMajorDto
    {
        public int ProgramId { get; set; }
        public int MajorId { get; set; }
        public int TermId { get; set; }
        public int SemesterId { get; set; }
    }
}