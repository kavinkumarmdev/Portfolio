namespace kavinkumar.dev.Models;

public class Experience
{
    public int Id { get; set; }
    public string Position { get; set; }
    public string CompanyName { get; set; }
    public string CompanyType { get; set; }
    public string CompanyUrl { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Duration { get; set; }
    public string Description { get; set; }
}