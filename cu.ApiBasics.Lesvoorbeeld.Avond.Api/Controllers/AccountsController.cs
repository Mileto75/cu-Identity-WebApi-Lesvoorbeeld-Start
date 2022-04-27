using cu.ApiBasics.Lesvoorbeeld.Avond.Api.DTOs.Accounts;
using cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
                return Ok(result.Messages);
            }
            return Unauthorized(result.Messages);
        }
    }
}
