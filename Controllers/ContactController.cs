using Microsoft.AspNetCore.Mvc;
using kavinkumar.dev.Data;
using kavinkumar.dev.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace kavinkumar.dev.Controllers
{
    public class ContactController : Controller
    {
        public ContactController()
        {
        }

        [HttpPost("Contact/Send")]
        public IActionResult Send([FromBody] ContactMessage message)
        {
            // Database removed - messages can be logged or handled via external services
            System.Diagnostics.Debug.WriteLine($"New Message from {message.Name} ({message.Email}): {message.Message}");
            return Ok(new { success = true, message = "Your message has been sent successfully!" });
        }

        [HttpPost("api/Contact")]
        public IActionResult Submit([FromForm] ContactMessage message)
        {
            return Ok(new { success = true, message = "Message received!" });
        }

    }
}
