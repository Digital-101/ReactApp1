using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReactApp1.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		//[HttpPost]
		//public IActionResult Post([FromBody] ContactForm model)
		//{
		//	// Handle form submission (e.g., save to database, send email)
		//	// Return appropriate response
		//	return Ok(new { Message = "Contact form submitted successfully!" });
		//}
	}
}
