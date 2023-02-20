namespace ISMS_API.DTOs
{
    public class GetBlockDto
    {
        public int BlockId { get; set; }
        public string BlockName { get; set; }
        public string Program { get; set; }
        public string Major { get; set; }
        public string Term { get; set; }
        public string Semester { get; set; }
        public bool IsActive { get; set; }
    }
}