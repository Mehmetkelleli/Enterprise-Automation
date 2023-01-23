using System.ComponentModel.DataAnnotations;

namespace isteksikayet.webui.Models
{
    public class Sign
    {
        [Required]
        [MinLength(3)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(10)]
        public string Password { get; set; }
    }
}
