using System.ComponentModel.DataAnnotations;

namespace Auth.FacebookAndVK.Models
{
    public class ExternalLoginViewModel
    {

        [Required]
        public string UserName { get; set; }

        [Required]
        public string ReturnUrl { get; set; }
    }
}
