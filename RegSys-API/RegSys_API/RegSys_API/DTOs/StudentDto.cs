namespace ISMS_API.DTOs
{
    public class StudentDto
    {
       // public int StudentId { get; set; }
        public string StudentNo { get; set; }
        public string Lrnno { get; set; }
        public PersonDto Person { get; set; }
        public ProgramDto Program { get; set; }
        public MajorDto Major { get; set; }
        public string YearLevel { get; set; }
        public bool? IsActive { get; set; }
    }
}
