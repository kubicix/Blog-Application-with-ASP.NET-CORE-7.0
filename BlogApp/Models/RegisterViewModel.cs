using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class RegisterViewModel{
        [Required]
        [Display(Name="Username")]
        public string? UserName { get; set; }
        [Required]
        [Display(Name="Name Surname")]
        public string? Name { get; set; }
    
        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail Adress")]
        public string? Email { get; set; }
        [Required]
        [StringLength(10,ErrorMessage ="{0} could be Max. 10, Min. 6 characters!",MinimumLength = 6),]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string? Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="Passwords didn't match")]
        [Display(Name ="Confirm Password")]
        public string? ConfirmPassword { get; set; }
    }
}