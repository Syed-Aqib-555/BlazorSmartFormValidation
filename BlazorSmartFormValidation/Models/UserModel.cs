using System.ComponentModel.DataAnnotations;

namespace BlazorSmartFormValidation.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = string.Empty;
    }
    
}