using System.ComponentModel.DataAnnotations;

namespace cu.ApiBasics.Lesvoorbeeld.Avond.Api.DTOs.Accounts
{
    public class AccountsRegisterRequestDto : AccountsLoginRequestDto
    {
        [Required(ErrorMessage = "Please provide {0}")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Please provide {0}")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Please provide {0}")]
        [Compare("Password", ErrorMessage = "Passwords must match!")]
        public string RepeatPassword { get; set; }
    }
}
