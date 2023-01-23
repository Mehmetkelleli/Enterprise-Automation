using System.ComponentModel.DataAnnotations;

namespace isteksikayet.webui.Models
{
    public class Register
    {
        [Required]
        [MinLength(3,ErrorMessage ="min 3 karakter ")]
        public string Name { get; set; }

        /// ////////////////////////////////////////
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        /// ////////////////////////////////////////
        [Required]
        public string ImgUrl { get; set; }

        /// ////////////////////////////////////////
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        
        /// ////////////////////////////////////////
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(10)]
        public string Password { get; set; }
       
        /// //////////////////////////////////////
        [Required]
        [DataType(DataType.Password)]
        [MinLength(10)]
        [Compare("Password")]
        public string Repassword { get; set; }
    }
}
