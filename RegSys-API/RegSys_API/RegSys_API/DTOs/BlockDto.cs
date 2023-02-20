namespace ISMS_API.DTOs
{
    public class BlockDto
    {
        public string BlockName { get; set; }
        public int ProgramId { get; set; }
        public int MajorId { get; set; }
        public int TermId { get; set; }
        public int SemesterId { get; set; }
        public bool IsActive { get; set; }
    }
}