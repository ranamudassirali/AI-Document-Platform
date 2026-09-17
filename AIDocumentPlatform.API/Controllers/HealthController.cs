using Microsoft.AspNetCore.Mvc;

namespace AIDocumentPlatform.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "healthy",
            service = "AI Document Platform",
            timestamp = DateTime.UtcNow
        });
    }
}