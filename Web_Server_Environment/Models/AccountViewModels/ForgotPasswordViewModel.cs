using System.ComponentModel.DataAnnotations;

namespace Web_Server_Environment.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
