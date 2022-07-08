using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace ToDoList.Controllers.Requests
{
    public class RegisterUserJsonRequest
    {
        //regex matching for alphanumerics and _-/!@$&*()
        [Required, MinLength(3), MaxLength(25), RegularExpression(@"^[a-zA-Z0-9_\-.@!$&*()]*$")]
        public string Username { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        //Required one capital, one digit and at least one of special characters: @$!%*?&.()-_+
        [Required, MinLength(8), MaxLength(60), RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&.()\-_\+])[A-Za-z\d@$!%*?&.()\-_\+]+$")]
        public string Password { get; set; }
        [Required, Compare(nameof(Password))]
        public string RepeatPassword { get; set; }
        [Required, Range(1, 1)]
        public bool Consent { get; set; }
    }
}
