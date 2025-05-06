using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prodigy_Task01.Service.Services;
using PRODIGY_Task01.Models.Dtos;

namespace PRODIGY_BD_Task01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService) => _userService = userService;
    

        [HttpPost("createUser")]
        public  ActionResult<UserDto> CreateUser(UserDto userDto)
        {
            if (userDto == null) return BadRequest("Invalid Operation");
            var user =  _userService.CreateUser(userDto);
            if (user == null) return BadRequest("Invalid Operation");
            return Ok(user);
        }

        [HttpPut("updateUser")]
        public ActionResult<UserDto> UpdateUser(string id,UpdateUserDto userDto)
        {
            if (id == null) return BadRequest("Invalid Operation");
            var user = _userService.UpdateUser(id,userDto);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpDelete("deleteUser")]
        public ActionResult<UserDto> DeleteUser(string id)
        {
            if (id == null) return BadRequest("Invalid Operation");
            var result = _userService.DeleteUser(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("user")]
        public ActionResult<UserDto> GetUser(string id)
        {
            if (id == null) return BadRequest("Invalid Operation");
            var user = _userService.GetUser(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
    }
}
