using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScalablePathTechnical.Data;
using ScalablePathTechnical.Models;

namespace ScalablePathTechnical.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersDBContext _context;

        public UsersController(UsersDBContext context)
        {
            _context = context;
        }
        private static readonly IEnumerable<User> _users = new List<User>()
            {
                new Models.User
                {
                    Id = "f909bbf6-3e17-11e9-b210-d663bd873d93",
                    Name = "John Doe",
                    Dob = new DateTime(1984, 03, 20),
                    Lead_Source = "email"
                },
                new Models.User
                {
                    Id = "35b6f974-3e18-11e9-b210-d663bd873d93",
                    Name = "Jane Doe",
                    Dob = new DateTime(1985, 7, 18),
                    Lead_Source = "twitter"
                },
                new Models.User
                {
                    Id = "5ec73e50-3e18-11e9-b210-d663bd873d93",
                    Name = "Marty McFly",
                    Dob = new DateTime(1968, 6, 12),
                    Lead_Source = "TwiTter"
                },
                new Models.User
                {
                    Id = "2167c344-3e19-11e9-b210-d663bd873d93",
                    Name = "Jennifer Parker",
                    Dob = new DateTime(1984, 3, 20),
                    Lead_Source = " e-mail"
                },
                new Models.User
                {
                    Id = "2167c344-3e19-11e9-b210-d663bd873d93",
                    Name = "Emmett Lathrop \"Doc\" Brown, Ph.D",
                    Dob = new DateTime(1932, 3, 20),
                    Lead_Source = "friends"
                }

        };


        [HttpGet]
        public IEnumerable<Models.User> GetUserItems()
        {
            return _users;
        }


        // GET: api/TaskItems
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<User>>> GetUserItems()
        //{
        //    return await _context.Users.ToListAsync();
        //}

    }
}