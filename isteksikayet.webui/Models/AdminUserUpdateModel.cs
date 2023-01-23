using isteksikayet.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace isteksikayet.webui.Models
{
    public class AdminUserUpdateModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }
        public string LocalNumber { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public bool Active { get; set; }
        public IFormFile ImgUrl { get; set; }
        public SelectList Departmants { get; set; }
        public List<string> Roles { get; set; }
        public int SelectDepartment { get; set; }
        public IList<string> roles { get; set; }
        public string StringImgUrl { get; set; }
        public string Id { get; set; }
        public bool EMailConfirm { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
