using System.ComponentModel.DataAnnotations;

namespace RentACarApplication.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(100,MinimumLength = 2)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Запомни ме")]
        public bool RememberMe { get; set; }
        public string LoginInValid { get; set; }
    }
}
