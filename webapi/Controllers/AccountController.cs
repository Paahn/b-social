using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class AccountController : ApiControllerBase
    {
        private readonly WebApiDbContext _context;
        public AccountController(WebApiDbContext context)
        {
            _context = context;
        }

        // POST: api/accounts/register
        [HttpPost("register")]
        public async Task<ActionResult<AppUser>> Register(string username, string password)
        {
            
        }
    }
}