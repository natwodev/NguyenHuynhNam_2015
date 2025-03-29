using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.Services;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Models;

namespace NguyenHuynhNam_2015.Controllers
{
    [Route("api/user")]
    [Authorize]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("get-user/{userId}")]
        [Authorize(Policy = "AdminOnly")]
        public async Task<ActionResult<UserDTO>> GetUserById(string userId)
        {
            var user = await _userService.GetByIdAsync(userId);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpGet("get-all-users")]
        [Authorize(Policy = "AdminOnly")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers()
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }

        [HttpPost("create-user")]
        [Authorize(Policy = "AdminOnly")]
        public async Task<ActionResult> CreateUser([FromBody] User user)
        {
            await _userService.CreateUserAsync(user);
            return CreatedAtAction(nameof(GetUserById), new { userId = user.UserId }, user);
        }

        [HttpPut("update-user/{userId}")]
        [Authorize(Policy = "AdminOnly")]
        public async Task<ActionResult> UpdateUser(string userId, [FromBody] User user)
        {
            if (userId != user.UserId) return BadRequest();
            await _userService.UpdateUserAsync(user);
            return NoContent();
        }

        [HttpPatch("lock-user/{userId}")]
        [Authorize(Policy = "AdminOnly")]
        public async Task<ActionResult> LockUser(string userId)
        {
            await _userService.LockUserAsync(userId);
            return NoContent();
        }
        
        [HttpPatch("reset-password/{userId}")]
        [Authorize(Policy = "AdminOnly")]
        public async Task<ActionResult> ResetPasswordAsync(string userId, [FromBody] string newPasswordHash)
        {
            await _userService.ResetPasswordAsync(userId, newPasswordHash);
            return NoContent();
        }

    }
}