using WebApi.Data;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    public class UsersController : ApiControllerBase
    {
        private readonly WebApiDbContext _context;
        public UsersController(WebApiDbContext context)
        {
            _context = context;
        }

        // api/users
        [HttpGet]
        public async Task <ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // api/users/3
        [HttpGet("{id}")]
        public async Task <ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}