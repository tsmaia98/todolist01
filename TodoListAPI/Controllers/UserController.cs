using Microsoft.AspNetCore.Mvc;
using TodoListAPI.Services;

[Route("TodoListAPI/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private UserService userService { get; set; }

    public UserController(UserService service)
    {
        this.userService = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var users = await userService.GetAllAsync();
            return Ok(users);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetOneById(int id)
    {
        try
        {
            var user = await userService.GetOneUserByIdAsync(id);
            return Ok(user);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
