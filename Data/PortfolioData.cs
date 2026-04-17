using System;
using System.Collections.Generic;
using kavinkumar.dev.Models;

namespace kavinkumar.dev.Data
{
    public static class PortfolioData
    {
        public static List<Education> Educations = new List<Education>
        {
            new Education
            {
                Id = 1,
                InstitutionName = "K.S.R Of Engineering(Autonomous)",
                Degree = "B.E",
                FieldOfStudy = "Computer Science and Engineering",
                GraduationYear = 2024,
                CGPA = 7.2m,
                Location = "Tiruchengode"
            },
            new Education
            {
                Id = 2,
                InstitutionName = "Mangalam Higher Secondary School",
                Degree = "HSLC",
                FieldOfStudy = "Computer Science and Maths",
                GraduationYear = 2020,
                CGPA = 60.6m,
                Location = "Anthiyur"
            },
            new Education
            {
                Id = 3,
                InstitutionName = "Mangalam Higher Secondary School",
                Degree = "SSLC",
                FieldOfStudy = "General",
                GraduationYear = 2018,
                CGPA = 72m,
                Location = "Anthiyur"
            }
        };

        public static List<Project> Projects = new List<Project>
        {
            new Project
            {
                Id = 9,
                Title = "Textile ERP - Supply Chain Management",
                Category = "Professional Enterprise Work",
                Description = "A mission-critical ERP system for end-to-end textile lifecycle management. Tracks data from raw cotton procurement to finished cloth delivery. Includes specialized modules for machine acquisition, lifecycle maintenance, and integrated sales performance tracking, hosted on internal protected infrastructure.",
                ImageUrl = "textile-erp.png",
                ProjectUrl = "#",
                GithubUrl = "",
                Technologies = "ASP.NET Core,SQL Server,SignalR,Enterprise IIS"
            },
            new Project
            {
                Id = 1,
                Title = "Chess Game",
                Category = "College Project",
                Description = "Designed and developed a feature-rich web-based chess game demonstrating my skills in web development, user interface design, and strategic implementation.",
                ImageUrl = "chess.jpg",
                ProjectUrl = "https://kavinkumarmuthusamy.github.io/chess/",
                GithubUrl = "",
                Technologies = "HTML,CSS,JavaScript"
            },
            new Project
            {
                Id = 2,
                Title = "Flames",
                Category = "College Project",
                Description = "Implemented the FLAMES relationship calculator as a web application, showcasing my web development capabilities and creative approach in creating interactive tools.",
                ImageUrl = "flames.jpg",
                ProjectUrl = "https://kavinkumarmuthusamy.github.io/flames/",
                GithubUrl = "",
                Technologies = "HTML,CSS,JavaScript"
            },
            new Project
            {
                Id = 3,
                Title = "Interview Feedback Form",
                Category = "College Project",
                Description = "Designed an intuitive and comprehensive interview feedback form web application, demonstrating my web development proficiency in creating user-friendly interfaces for data collection and analysis.",
                ImageUrl = "feedback.png",
                ProjectUrl = "https://kavinkumarmuthusamy.github.io/feedback/",
                GithubUrl = "",
                Technologies = "HTML,CSS,JavaScript"
            },
            new Project
            {
                Id = 4,
                Title = "Stone Paper Scissor",
                Category = "College Project",
                Description = "Implemented the classic 'Stone Paper Scissors' game as a web application, highlighting my web development skills and providing a nostalgic and interactive gaming experience.",
                ImageUrl = "sps.jpg",
                ProjectUrl = "https://kavinkumarmuthusamy.github.io/stonpapersiscergame/",
                GithubUrl = "",
                Technologies = "HTML,CSS,JavaScript"
            },
            new Project
            {
                Id = 5,
                Title = "Tic Tac Toe",
                Category = "College Project",
                Description = "Engineered a novel twist on the classic Tic Tac Toe game, introducing strategic layers and captivating visuals in a dynamic web application that highlights my innovation and web development prowess.",
                ImageUrl = "xox.jpg",
                ProjectUrl = "https://kavinkumarmuthusamy.github.io/xox/",
                GithubUrl = "",
                Technologies = "HTML,CSS,JavaScript"
            },
            new Project
            {
                Id = 6,
                Title = "Java Programs Collection",
                Category = "College Project",
                Description = "Developed a diverse collection of over 50 Java programs, each showcasing various programming concepts and problem-solving skills.",
                ImageUrl = "java.jpg",
                ProjectUrl = "https://github.com/kavinkumarmuthusamy/javaprograms",
                GithubUrl = "",
                Technologies = "Java"
            },
            new Project
            {
                Id = 7,
                Title = "Brain Puzzle Game",
                Category = "College Project",
                Description = "Devised a 17-click brain puzzle game where strategically selecting central values triggers cascading number reductions.",
                ImageUrl = "brain.jpg",
                ProjectUrl = "https://kavinkumarmuthusamy.github.io/brain/",
                GithubUrl = "",
                Technologies = "HTML,CSS,JavaScript"
            },
            new Project
            {
                Id = 8,
                Title = "Login & Static Webpage",
                Category = "College Project",
                Description = "Securely access your account with our user-friendly login page, prioritizing privacy and offering a seamless experience.",
                ImageUrl = "login.jpg",
                ProjectUrl = "https://kavinkumarmuthusamy.github.io/login/",
                GithubUrl = "",
                Technologies = "HTML,CSS,JavaScript"
            }
        };

        public static List<Skill> Skills = new List<Skill>
        {
            // Backend
            new Skill { Id = 1, Name = ".NET 8", Icon = "fas fa-cube", Category = "Backend" },
            new Skill { Id = 2, Name = ".NET Core MVC", Icon = "fas fa-code-branch", Category = "Backend" },
            new Skill { Id = 3, Name = "Web API", Icon = "fas fa-server", Category = "Backend" },
            new Skill { Id = 4, Name = "EF Core", Icon = "fas fa-database", Category = "Backend" },
            new Skill { Id = 5, Name = "Dapper", Icon = "fas fa-bolt", Category = "Backend" },

            // Architecture
            new Skill { Id = 6, Name = "Clean Architecture", Icon = "fas fa-layer-group", Category = "Architecture" },
            new Skill { Id = 7, Name = "SOLID Principles", Icon = "fas fa-square-check", Category = "Architecture" },
            new Skill { Id = 8, Name = "Dependency Injection", Icon = "fas fa-vial", Category = "Architecture" },
            new Skill { Id = 9, Name = "Microservices", Icon = "fas fa-cubes", Category = "Architecture" },

            // Database
            new Skill { Id = 10, Name = "PostgreSQL", Icon = "fas fa-database", Category = "Database" },
            new Skill { Id = 11, Name = "Oracle DB", Icon = "fas fa-database", Category = "Database" },
            new Skill { Id = 12, Name = "SQL Server", Icon = "fas fa-database", Category = "Database" },

            // Frontend
            new Skill { Id = 13, Name = "React", Icon = "fab fa-react", Category = "Frontend" },
            new Skill { Id = 14, Name = "Tailwind CSS", Icon = "fab fa-css3", Category = "Frontend" },
            new Skill { Id = 15, Name = "JavaScript", Icon = "fab fa-js", Category = "Frontend" },
            new Skill { Id = 16, Name = "Bootstrap", Icon = "fab fa-bootstrap", Category = "Frontend" },
            new Skill { Id = 17, Name = "HTML5/CSS3", Icon = "fab fa-html5", Category = "Frontend" },

            // Security & Real-time
            new Skill { Id = 18, Name = "JWT Auth", Icon = "fas fa-user-shield", Category = "Security & Real-time" },
            new Skill { Id = 19, Name = "SignalR", Icon = "fas fa-broadcast-tower", Category = "Security & Real-time" },

            // Tools
            new Skill { Id = 20, Name = "GitHub", Icon = "fab fa-github", Category = "Tools" },
            new Skill { Id = 21, Name = "Swagger", Icon = "fas fa-file-code", Category = "Tools" },
            new Skill { Id = 22, Name = "Postman", Icon = "fas fa-paper-plane", Category = "Tools" },
            new Skill { Id = 23, Name = "IIS Deployment", Icon = "fas fa-cloud-upload-alt", Category = "Tools" }
        };

        public static List<Experience> Experiences = new List<Experience>
        {
            new Experience
            {
                Id = 1,
                CompanyName = "Sakthi Infra Tex",
                Position = "Software Developer",
                Duration = "June 2024 - Present",
                CompanyUrl = "https://sakthiinfra.com/",
                CompanyType = "Product Based Company",
                Description = "Working as a Software Developer, specializing in ASP.NET Core and Enterprise applications.",
                StartDate = new DateTime(2024, 6, 1),
                EndDate = null
            }
        };

        public static List<Certificate> Certificates = new List<Certificate>
        {
            new Certificate { Id = 1, Title = "Wipro TalentNext Java Full Stack", IssuedBy = "WIPRO", IssueDate = new DateTime(2023, 10, 6), CertificateUrl = "https://drive.google.com/file/d/1Iso68eIRfs-p9MLUxLaWx-UoUgsuVPm1/view?usp=sharing" },
            new Certificate { Id = 2, Title = "Ethical Hacking Master Class", IssuedBy = "Udemy", IssueDate = new DateTime(2023, 9, 4), CertificateUrl = "https://drive.google.com/file/d/1NNEEituZlbqC2aj2SGDX_l3p3sDDMkhI/view?usp=sharing" },
            new Certificate { Id = 3, Title = "JavaScript for Beginners", IssuedBy = "Udemy", IssueDate = new DateTime(2023, 6, 15), CertificateUrl = "https://drive.google.com/file/d/1yQD5WE0N4_FvJQ2ZJjJ19b6X1gGzj38i/view?usp=sharing" },
            new Certificate { Id = 4, Title = "CSS, JS & PHP Complete Course", IssuedBy = "Udemy", IssueDate = new DateTime(2023, 6, 15), CertificateUrl = "https://drive.google.com/file/d/1nPz-9Xgy4eOg4zz6cIxwe0PZJ_h1jUgm/view?usp=sharing" },
            new Certificate { Id = 5, Title = "Introduction to Cybersecurity", IssuedBy = "Cisco", IssueDate = new DateTime(2022, 9, 23), CertificateUrl = "https://drive.google.com/file/d/1SmVsrwCqC6Y6NzX2ivhYySEmJcGvXK2p/view" },
            new Certificate { Id = 6, Title = "Code Debugging & Code Hunter", IssuedBy = "UDHYAM'23", IssueDate = new DateTime(2023, 3, 24), CertificateUrl = "https://drive.google.com/file/d/1pRaptyQ_AKMYqAmt092ESGZxEDMBIaZg/view?usp=sharing" },
            new Certificate { Id = 7, Title = "Paper Presentation", IssuedBy = "UDHYAM'23 & ASTHRA", IssueDate = new DateTime(2023, 3, 24), CertificateUrl = "https://drive.google.com/file/d/1YEz8I4r8ZWERFkWTWEoy2thAPubMQ7tC/view?usp=sharing" },
            new Certificate { Id = 8, Title = "Web Designing & Quiz", IssuedBy = "ASTHRA 2022", IssueDate = new DateTime(2022, 5, 20), CertificateUrl = "https://drive.google.com/file/d/1WkIKoLhCBUNJjlYtn5UJAOG8le7IJWUp/view?usp=sharing" },
            new Certificate { Id = 9, Title = "Mitsuya-Kai Karate-Do India", IssuedBy = "Shihan J.S. Jacob", IssueDate = new DateTime(2014, 11, 9), CertificateUrl = "https://drive.google.com/file/d/1QC7Y04F1zOKfPUjQx_58mZlXc0WPLtof/view?usp=sharing" },
            new Certificate { Id = 10, Title = "State Level Handwriting", IssuedBy = "Brainobrain", IssueDate = new DateTime(2014, 9, 5), CertificateUrl = "https://drive.google.com/file/d/1w9kRanuYA4D1V5GzBjTI4yV7JjKcvZbg/view?usp=sharing" },
            new Certificate { Id = 11, Title = "Karate - Green Belt", IssuedBy = "Mitsuya-Kai", IssueDate = new DateTime(2014, 1, 1), CertificateUrl = "https://drive.google.com/file/d/1AHvDflP-KnBz6nXPaEWRLIXTpFRCfUNZ/view?usp=sharing" },
            new Certificate { Id = 12, Title = "Hindi - Prathamic", IssuedBy = "DBHP Sabha", IssueDate = new DateTime(2016, 5, 25), CertificateUrl = "https://drive.google.com/file/d/181wqeZKy2ownZaPD6pa_xu9uwIoXWWP3/view?usp=sharing" },
            new Certificate { Id = 13, Title = "Schooling Achievement", IssuedBy = "Various", IssueDate = new DateTime(2018, 1, 1), CertificateUrl = "https://drive.google.com/file/d/1M8ieePIcTfVIaYu0CEml_0sIHZeEEB48/view?usp=sharing" }
        };
    }
}
