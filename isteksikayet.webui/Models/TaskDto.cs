using isteksikayet.Entity;
using isteksikayet.webui.Identity;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace isteksikayet.webui.Models
{
    public class TaskDto
    {
        [Required(ErrorMessage ="Bu alan Zorunludur")]
       public string Title { get; set; }
        [Required(ErrorMessage = "Bu alan Zorunludur")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Bu alan Zorunludur")]
        public int TaskId { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public IFormFile File { get; set; }
        public User CreatedUser { get; set; }
        public User TaskUser { get; set; }
        public state State { get; set; }
        public string FileUrl  { get; set; }
    }
}
