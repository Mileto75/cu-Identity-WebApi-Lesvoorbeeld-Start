using System.ComponentModel.DataAnnotations;

namespace cu.ApiBasics.Lesvoorbeeld.Avond.Api.DTOs.Accounts
{
    public class AccountsLoginRequestDto
    {
        [Required(ErrorMessage = "Please provide {0}")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please provide {0}")]

        public string Password { get; set; }
    }
}
