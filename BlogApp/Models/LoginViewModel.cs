using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class LoginViewModel{
        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail Adress")]
        public string? Email { get; set; }
        [Required]
        [StringLength(10,ErrorMessage ="{0} could be Max. 10, Min. 6 characters!",MinimumLength = 6),]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string? Password { get; set; }
    }
}