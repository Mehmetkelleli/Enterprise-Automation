using isteksikayet.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace isteksikayet.webui.Models
{
    public class AdminUserAddModel
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
        [Required]
        public IFormFile ImgUrl { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Active { get; set; }
        public List<Department> Departmants { get; set; }
        public IQueryable Roles { get; set; }
        public int SelectDepartment { get; set; }
        public string[] roles { get; set; }
    }
}
