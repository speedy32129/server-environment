using System.ComponentModel.DataAnnotations;

namespace Web_Server_Environment.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
