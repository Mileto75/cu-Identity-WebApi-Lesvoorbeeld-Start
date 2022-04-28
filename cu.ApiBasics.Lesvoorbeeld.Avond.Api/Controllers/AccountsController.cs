using cu.ApiBasics.Lesvoorbeeld.Avond.Api.DTOs.Accounts;
using cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace cu.ApiBasics.Lesvoorbeeld.Avond.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    
    public class AccountsController : ControllerBase
    {
        //inject our userService
        private readonly IUserService _userService;

        public AccountsController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AccountsLoginRequestDto accountsLoginRequestDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            //attempt to log in the user
            var result = await _userService.Login(accountsLoginRequestDto.Username,
                accountsLoginRequestDto.Password);
            if(result.Success)
            {
                return Ok(new AccountsLoginResponseDto { Token = result.Messages.First()});
            }
            return Unauthorized(result.Messages);
        }
        [HttpPost("Register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(AccountsRegisterRequestDto accountsRegisterRequestDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            //call userservice register method
            var result = await _userService.Register(accountsRegisterRequestDto.Firstname,
                accountsRegisterRequestDto.Lastname,
                accountsRegisterRequestDto.Username,
                accountsRegisterRequestDto.Password
                );
            if(!result.Success)
            {
                return BadRequest(result.Messages);
            }
            return Ok(result.Messages);
        }
        [HttpGet("Users")]
        
        public IActionResult Users()
        {
            return Ok( _userService.GetUsers().Select(u => 
            new {
                Firstname = u.Firstname,
                Lastname = u.Lastname,
                Email = u.Email
            }));
        }
    }

}
