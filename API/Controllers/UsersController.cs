using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] // NOTA mettendo controller tra quadre corrisponde a api/users (prende il nome della class senza Controller)
public class UsersController : ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();

        return users;
    }

    [HttpGet("{id}")] //corrisponde ad esempio a /api/users/2
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await _context.Users.FindAsync(id);

        return user;
    }
}

