using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MyAnotherController : ControllerBase
{
    [HttpGet("method1")]
    public IActionResult GetAnother()
    {
        return Ok(new { Message = "This is another controller!" });
    }
}