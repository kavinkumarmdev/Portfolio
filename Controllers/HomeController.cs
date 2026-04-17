using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using kavinkumar.dev.Models;
using kavinkumar.dev.Data;

namespace kavinkumar.dev.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new DashboardViewModel
        {
            Educations = PortfolioData.Educations,
            Projects = PortfolioData.Projects,
            Certificates = PortfolioData.Certificates,
            Skills = PortfolioData.Skills,
            Experiences = PortfolioData.Experiences,
            Testimonials = PortfolioData.Testimonials,
            Messages = PortfolioData.Messages
        };

        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
