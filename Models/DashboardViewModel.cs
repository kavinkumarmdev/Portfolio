using System.Collections.Generic;

namespace kavinkumar.dev.Models;

public class DashboardViewModel
{
    public List<Education> Educations { get; set; }
    public List<Project> Projects { get; set; }
    public List<Certificate> Certificates { get; set; }
    public List<Skill> Skills { get; set; }
    public List<Experience> Experiences { get; set; }
    public List<Testimonial> Testimonials { get; set; }
    public List<ContactMessage> Messages { get; set; }
}