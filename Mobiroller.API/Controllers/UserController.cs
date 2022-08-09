using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobiroller.Core.DTOs;
using Mobiroller.Core.Services;

namespace Mobiroller.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : CustomBaseController
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto createUserDto)
        {
            return ActionResultInstance(await _userService.CreateUserAsync(createUserDto));
        }
        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUser(string userName)
        {
            return ActionResultInstance(await _userService.GetUserByNameAsync(userName));
        }
    }
}
