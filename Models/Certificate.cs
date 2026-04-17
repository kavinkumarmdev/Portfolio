namespace kavinkumar.dev.Models;

public class Certificate
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string IssuedBy { get; set; }
    public DateTime IssueDate { get; set; }
    public string CertificateUrl { get; set; }
}