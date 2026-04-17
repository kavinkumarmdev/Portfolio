namespace kavinkumar.dev.Models;

public class Education
{
    public int Id { get; set; }
    public string Degree { get; set; }
    public string InstitutionName { get; set; }
    public int GraduationYear { get; set; }
    public decimal? CGPA { get; set; }
    public string Location { get; set; }
}