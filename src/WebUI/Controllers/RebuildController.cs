using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

[ApiController]
[Route("[controller]")]
public class RebuildController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<RebuildController> _logger;

    public RebuildController(ILogger<RebuildController> logger)
    {
        _logger = logger;
    }
}