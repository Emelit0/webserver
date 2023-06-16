using Microsoft.AspNetCore.Mvc;
using webserver.Entities;

namespace webserver.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private static readonly int[] Users = { 1, 2, 3, 4, 5 };

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    //get all users

    [HttpGet (Name = "users")]
    
    public Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return Task.FromResult<ActionResult<IEnumerable<User>>>(Ok(Users));
    }
}