using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class ValidModel
    {
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "FirstNameRequired")]
        [StringLength(30, ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "FirstNameStringLength")]
        public string FirstName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "SecondNameRequired")]
        [StringLength(30, ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "SecondNameStringLength")]
        public string SecondName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "EmailRequired")]
        [EmailAddress(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "EmailEmailAddress")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "PasswordRequired")]
        [StringLength(50, ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "PasswordStringLength", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
