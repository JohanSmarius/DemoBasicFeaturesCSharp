using Microsoft.AspNetCore.Mvc;
using Shared;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class MemberController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMembers()
    {
        return Ok(new List<MemberDto>());
    }
}