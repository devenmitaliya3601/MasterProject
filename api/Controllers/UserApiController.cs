using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using mvc.Repositories;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserApiController : ControllerBase
    {
        private readonly IUserRepositories _userRepositories;

        public UserApiController(IUserRepositories userRepositories)
        {
            _userRepositories = userRepositories;
        }

        [HttpPost("Login")] // Specify the route for the Login action
        public IActionResult Login(tblLogin log)
        {
            int result = _userRepositories.LoginWithApi(log);
            if (result > 0)
            {
                return Ok("Valid");
            }
            else
            {
                return BadRequest("Not Valid");
            }
        }

        [HttpPost("register")]
        public IActionResult Register(tblUser user)
        {
            _userRepositories.Register(user);
            return Ok(new { message = "User registered successfully" });
        }
    }
}
