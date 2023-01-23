using System.ComponentModel.DataAnnotations;

namespace isteksikayet.webui.Models
{
    public class ResetPassword
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string UserToken { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(10)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(10)]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
